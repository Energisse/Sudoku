using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.IO;
using System.Windows.Forms;
using Sodoku.Composants;

namespace Sodoku
{
    public enum Difficulte : int
    {
        Facile = 4,
        Moyen = 3,
        Difficile = 2,
        Extreme = 1
    }
    public class Sudoku
    {
        private readonly Timer Timer;
        [JsonProperty]
        public int Taille { get; private set; }
        //Largeur du groupe ex : Une grille 9*9 a 9 groupes de 3*3 de largeur 3, une grille 12*12 a 12 groupes de 4*3 de largeur 4
        [JsonProperty]
        public int LargeurGroupe { get; private set; }
        //Hauteur du groupe ex : Une grille 9*9 a 9 groupes de 3*3 de hauteur 3, une grille 12*12 a 12 groupes de 4*3 de hauteur 3
        public int HauteurGroupe { get; private set; }
        [JsonProperty]
        public Case[,] Grille { get; private set; }
        [JsonProperty]
        public int VieRestante { get; private set; }
        [JsonProperty]
        public int IndiceRestant { get; private set; }
        [JsonProperty]
        public int CaseRestante { get; private set; }
        [JsonProperty]
        public readonly Difficulte Niveau;

        [JsonProperty]
        public int Temps { get; private set; }

        //dateTime de création permetant a l'identification de la partie parmis les parties enregistré
        public long DateTimeCreation { get; private set; }

        [JsonConstructor]
        private Sudoku(int Taille, Difficulte Niveau, int VieRestante, int IndiceRestant, Case[,] Grille, int CaseRestante, long DateTimeCreation, int LargeurGroupe, int HauteurGroupe, int Temps)
        {
            this.Taille = Taille;
            this.VieRestante = VieRestante;
            this.IndiceRestant = IndiceRestant;
            this.Grille = Grille;
            this.CaseRestante = CaseRestante;
            this.DateTimeCreation = DateTimeCreation;
            this.Niveau = Niveau;
            this.HauteurGroupe = HauteurGroupe;
            this.LargeurGroupe = LargeurGroupe;
            this.Temps = Temps;
            this.Timer = new Timer();
            this.Timer.Tick += new EventHandler(TimerEvent);
            this.Timer.Interval = 1000;
            if (!this.EstMort() && !this.AGagne())
            {
                this.Timer.Start();
            }
        }

        public void Tick(Action<object, EventArgs> e)
        {
            this.Timer.Tick += new EventHandler(e);
        }

        private void CalculTailleGroupe()
        {
            int a = (int)Math.Truncate(Math.Sqrt(this.Taille));

            while (a > 0)
            {
                if ((int)(this.Taille / a) == (this.Taille / (double)a)) break;
                a--;
            }

            this.HauteurGroupe = a;
            this.LargeurGroupe = this.Taille / HauteurGroupe;
        }

        public Sudoku(int taille = 9, Difficulte Niveau = Difficulte.Facile, int vie = 3, int indice = 3)
        {
            this.Timer = new Timer();
            this.Timer.Tick += new EventHandler(TimerEvent);
            this.Timer.Interval = 1000;
            this.Timer.Start();

            this.DateTimeCreation = DateTime.Now.ToFileTime();
            this.Taille = taille;
            this.CaseRestante = 0;
            this.Niveau = Niveau;

            CalculTailleGroupe();

            this.VieRestante = vie;
            this.IndiceRestant = indice;
            Grille = new Case[taille, taille];

            //Création de la grille a partir d'une grille vide
            int[,]  grille = new int[taille, taille];
            Resoudre(grille);

            //Création de la grille des indices
            int[,]  grilleIndice = (int[,])grille.Clone();

            int suppresion = 0;
            int iteration = 0;
            //AMERLIORER LA SUPPRESSION DES CHIFFRES
            foreach (int i in SuiteAleatoire(0, taille*taille))
            {
                int x = i % taille;
                int y = i / taille;
                int temp = grilleIndice[x, y];
                grilleIndice[x, y] = 0;
                int[,] copie = (int[,])grilleIndice.Clone();

                if (this.ResoudreCompteur(copie, 0, 0) >= 2)
                {
                    grilleIndice[x, y] = temp;

                }
                //Limitation pour accelerer la génération
                else
                {
                    CaseRestante++;
                    if (suppresion++ >= taille * taille / (int)this.Niveau)
                    {
                        break;
                    };
                }
                System.Diagnostics.Debug.WriteLine(suppresion + " " + ((double)iteration++ / ((double)taille * taille))*100 + "%");

            }
            for (int x = 0; x < taille; x++)
            {
                for(int y =0; y <taille; y++)
                {
                    if(grilleIndice[x, y] == grille[x, y])
                    {
                        Grille[x, y] = new Case(taille, grille[x, y],true);
                    }
                    else
                    {
                        Grille[x, y] = new Case(taille, grille[x, y],false);
                    }
                }
            }
        }
        public void TimerEvent(object sender, EventArgs e)
        {
            this.Temps++;
        }
        public bool EstMort()
        {
            return VieRestante == 0;
        }

        public bool AGagne()
        {
            return CaseRestante == 0;
        }

        public bool CaseEstValide(int v, int x, int y)
        {
            return Grille[x, y].EstValide();
        }
        public bool Resoudre(int[,] grille, int x = 0, int y = 0)
        {
            if (y == Taille) return true;
            if (x == Taille) return Resoudre(grille, 0, y + 1);
            if (grille[x, y] != 0) return Resoudre(grille, x + 1, y);
            foreach (int i in SuiteAleatoire(1,Taille+1))
            {
                if (NestPasDansLaLigne(grille,i, x, y) && NestPasDansLaColonne(grille,i, x, y) && ControleInterieurCarre(grille,i, x, y))
                {
                    grille[x, y] = i;
                    if (Resoudre(grille, x + 1, y)) return true;
                    grille[x, y] = 0;
                }
            }
            return false;
        }

        private int ResoudreCompteur(int[,] grille, int x, int y)
        {
            if (y == Taille) return 1;
            if (x == Taille) return ResoudreCompteur(grille, 0, y + 1);
            if (grille[x, y] != 0) return ResoudreCompteur(grille, x + 1, y);
            int possibilite = 0;

            for (int i = 1; i <= Taille; i++)
            {
                if (NestPasDansLaLigne(grille,i, x, y) && NestPasDansLaColonne(grille,i, x, y) && ControleInterieurCarre(grille,i, x, y))
                {
                    grille[x, y] = i;
                    possibilite += ResoudreCompteur(grille, x + 1, y);
                    if (possibilite >= 2) return possibilite;
                    grille[x, y] = 0;
                }
            }
            return possibilite;
        }

        private bool NestPasDansLaLigne(int[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < Taille; i++)
            {
                if (grille[i, y] == valeur) return false;
            }
            return true;
        }

        private bool NestPasDansLaColonne(int[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < Taille; i++)
            {
                if (grille[x, i] == valeur) return false;
            }
            return true;
        }

        private bool ControleInterieurCarre(int[,] grille, int valeur, int x, int y)
        {

            int colonneAbsolue = (x / this.LargeurGroupe) * this.LargeurGroupe;
            int ligneAbsolue = (y / this.HauteurGroupe) * this.HauteurGroupe;
            for (int colonne = colonneAbsolue; colonne < colonneAbsolue + this.LargeurGroupe; colonne++)
            {
                for (int ligne = ligneAbsolue; ligne < ligneAbsolue + this.HauteurGroupe; ligne++)
                {
                    if (grille[colonne, ligne] == valeur) return false;
                }
            }
            return true;
        }

        public void EffacerNote(int x, int y)
        {
            if (EstMort()) return;
           Grille[x, y].EffacerNotes();
            Sauvegarde.Sauvegarder(this);
        }

        public void Noter( int x, int y,int v)
        {
            if (EstMort()) return;
            this.Grille[x, y].Notes[v - 1] = this.Grille[x, y].Notes[v - 1] == 0 ? v : 0;
            Sauvegarde.Sauvegarder(this);
        }

        public void Effacer(int x, int y)
        {
            if (EstMort()) return;
            if (!Grille[x, y].EstUnIndice())
            {
                if (Grille[x, y].EstValide())
                {
                    CaseRestante++;
                }
                Grille[x, y].Valeur = 0;
            }
            Sauvegarde.Sauvegarder(this);
        }

        public bool Jouer( int x, int y, int v)
        {
            if (EstMort()) return false;

            if (Grille[x, y].EstUnIndice())  return true;
            Grille[x, y].Valeur = v;
            if (!CaseEstValide(v, x, y))
            {
                /*La case joué n'est pas bonne*/
                VieRestante--;
                if (EstMort()) this.Timer.Stop();
                Sauvegarde.Sauvegarder(this);
                return false;
            }
            /*La case joué est bonne*/
            CaseRestante--;
            if(AGagne()) this.Timer.Stop();
            Sauvegarde.Sauvegarder(this);
            return true;
        }

        public (int x, int y,int v) Indice()
        {
            if (IndiceRestant == 0 || VieRestante == 0) return (-1, -1,-1);
            //On parcours le tableau de facon aléatoire
            foreach (int x in SuiteAleatoire(0, Taille))
            {
                foreach (int y in SuiteAleatoire(0, Taille))
                {
                    //On applique un indice uniquement au cases fause ou non remplise
                    if (Grille[x, y].EstUnIndice()) continue;
                    if (Grille[x, y].EstValide()) continue;
                    IndiceRestant--;
                    return (x, y, Grille[x, y].Solution);
                }
            }
            Sauvegarde.Sauvegarder(this);
            return (-1,-1,-1);
        }

        private static int[] SuiteAleatoire(int debut, int fin)
        {
            Random rnd = new Random();
            int[] liste = new int[fin - debut];
            for (int i = fin - debut - 1; i >= 0; i--)
            {
                liste[i] = i + debut;
            }
            for (int i = fin-debut - 1; i >= 0; i--)
            {
                int k = rnd.Next(0, fin-debut-1);
                (liste[i], liste[k]) = (liste[k], liste[i]);
            }
            return liste;
        }
        public void Dispose()
        {
            this.Timer.Stop();
            this.Timer.Dispose();
        }
    }

    public class Case
    {
        public int Solution { get; protected set; }
        public int Taille;
        public int[] Notes;
        public bool Indice;
        public int Valeur;

        public Case(int Taille, int Solution,bool Indice = false)
        {
            this.Solution = Solution;
            this.Valeur = Indice ? Solution : 0;
            this.Indice = Indice;
            this.Taille = Taille;
            this.Notes = new int[Indice ? 0 : Taille];
        }

        public bool EstValide()
        {
            return this.Valeur == this.Solution;
        }

        public bool EstUnIndice()
        {
            return Indice;
        }

        public bool EstJouable()
        {
            return !this.EstUnIndice() && this.EstVide();
        }

        public void EffacerNotes()
        {
            for(int i = 0; i < this.Notes.Length; i++)
            {
                this.Notes[i] = 0;
            }
        }

        public bool EstVide()
        {
            return this.Valeur == 0;
        }
    }
}
