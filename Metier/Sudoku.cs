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
        //Grille contenant les cases
        public Case[,] Grille { get; private set; }
        [JsonProperty]
        public int VieRestante { get; private set; }
        [JsonProperty]
        public int IndiceRestant { get; private set; }
        [JsonProperty]
        //CaseRestante avant la victoire
        private int CaseRestante;
        [JsonProperty]
        //Nombre restants de chaque nombre
        public int[] NombreRestant;
        [JsonProperty]
        public readonly Difficulte Difficulte;
        //temps de jeu
        [JsonProperty]
        public int Temps { get; private set; }
        //dateTime de création permetant a l'identification de la partie parmis les parties enregistré
        public long DateTimeCreation { get; private set; }

        //Constructeur de la sauvegarde JSON
        [JsonConstructor]
        private Sudoku(int Taille, Difficulte Difficulte, int VieRestante, int IndiceRestant, Case[,] Grille, int CaseRestante, long DateTimeCreation, int LargeurGroupe, int HauteurGroupe, int Temps, int[] NombreRestant)
        {
            this.Taille = Taille;
            this.VieRestante = VieRestante;
            this.IndiceRestant = IndiceRestant;
            this.Grille = Grille;
            this.CaseRestante = CaseRestante;
            this.DateTimeCreation = DateTimeCreation;
            this.Difficulte = Difficulte;
            this.HauteurGroupe = HauteurGroupe;
            this.LargeurGroupe = LargeurGroupe;
            this.Temps = Temps;
            this.Timer = new Timer();
            this.Timer.Tick += new EventHandler(TimerEvent);
            this.Timer.Interval = 1000;
            this.NombreRestant = NombreRestant;
            if (!this.EstMort() && !this.AGagne())
            {
                this.Timer.Start();
            }
        }

        public Sudoku(int taille = 9, Difficulte Difficulte = Difficulte.Facile, int vie = 3, int indice = 3)
        {
            this.Timer = new Timer();
            this.Timer.Tick += new EventHandler(TimerEvent);
            this.Timer.Interval = 1000;
            this.Timer.Start();

            this.DateTimeCreation = DateTime.Now.ToFileTime();
            this.Taille = taille;
            this.CaseRestante = 0;
            this.Difficulte = Difficulte;

            CalculTailleGroupe();

            this.VieRestante = vie;
            this.IndiceRestant = indice;
            Grille = new Case[taille, taille];

            //Création de la grille a partir d'une grille vide
            int[,]  grille = new int[taille, taille];
            Resoudre(grille);

            //Initialisation du tableau des nombres restants
            NombreRestant = new int[taille];


            //Création de la grille des indices
            int[,]  grilleIndice = (int[,])grille.Clone();

            int suppresion = 0;
            //AMERLIORER LA SUPPRESSION DES CHIFFRES
            //Suppression dans un ordre aleatoire pour eviter un groupement de chiffre a la fin
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
                    //Soustrait le nombre supprimé a la liste des nombres restant
                    NombreRestant[temp - 1]++;
                    CaseRestante++;
                    if (suppresion++ >= taille * taille / (int)this.Difficulte)
                    {
                        break;
                    };
                }
            }

            //Ajoute les cases au tableau
            for (int x = 0; x < taille; x++)
            {
                for(int y =0; y <taille; y++)
                {
                    //Est un indice
                    if(grilleIndice[x, y] != 0)
                    {
                        Grille[x, y] = new Case(taille, grille[x, y],true);
                    }
                    else //N'est pas un indice
                    {
                        Grille[x, y] = new Case(taille, grille[x, y],false);
                    }
                }
            }
        }

        //Tick du timer
        public void Tick(Action<object, EventArgs> e)
        {
            this.Timer.Tick += new EventHandler(e);
        }

        //Calcul la taille des groupe de cases ex: pour une grille 9x9 les groupes sont 3x3, pour 10x10 c'est 5x2
        private void CalculTailleGroupe()
        {
            int hauteur = (int)Math.Truncate(Math.Sqrt(this.Taille));

            while (hauteur > 0)
            {
                if ((int)(this.Taille / hauteur) == (this.Taille / (double)hauteur)) break;
                hauteur--;
            }

            this.HauteurGroupe = hauteur;
            this.LargeurGroupe = this.Taille / HauteurGroupe;

        }

        //Evenement du timer
        public void TimerEvent(object sender, EventArgs e)
        {
            this.Temps++;
        }
        //Retourne si le joueur est mort
        public bool EstMort()
        {
            return VieRestante == 0;
        }
        
        //Retourne si le joueur a gagné
        public bool AGagne()
        {
            return CaseRestante == 0;
        }

        //Resouds une grille
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

        //Resouds une grille et retourne le nombre de solution possible jusqu'a 2
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

        //Retourne si un element n'est pas dans la ligne
        private bool NestPasDansLaLigne(int[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < Taille; i++)
            {
                if (grille[i, y] == valeur) return false;
            }
            return true;
        }

        //Retourne si un element n'est pas dans la colonne
        private bool NestPasDansLaColonne(int[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < Taille; i++)
            {
                if (grille[x, i] == valeur) return false;
            }
            return true;
        }

        //Retourne si un element n'est pas dans un carré
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

        //Efface une note
        public void EffacerNote(int x, int y)
        {
            if (EstMort()) return;
            Grille[x, y].EffacerNotes();
            Sauvegarde.Sauvegarder(this);
        }

        //Note
        public void Noter( int x, int y,int v)
        {
            if (EstMort()) return;
            //Changement de l'etat de la note affin de l'activer/enlever
            this.Grille[x, y].Notes[v - 1] = !this.Grille[x, y].Notes[v - 1];
            Sauvegarde.Sauvegarder(this);
        }

        //Efface une case
        public void Effacer(int x, int y)
        {
            if (EstMort()) return;
            if (!Grille[x, y].EstUnIndice())
            {
                if (Grille[x, y].EstValide())
                {
                    CaseRestante++;
                    NombreRestant[Grille[x, y].Valeur-1]++;
                }
                Grille[x, y].Valeur = 0;
            }
            Sauvegarde.Sauvegarder(this);
        }

        //Joue une case
        public bool Jouer( int x, int y, int v)
        {
            if (EstMort()) return false;

            if (Grille[x, y].EstUnIndice())  return true;
            Grille[x, y].Valeur = v;
            if (!Grille[x, y].EstValide())
            {
                /*La case joué n'est pas bonne*/
                VieRestante--;
                if (EstMort()) this.Timer.Stop();
                Sauvegarde.Sauvegarder(this);
                return false;
            }
            /*La case joué est bonne*/
            CaseRestante--;
            NombreRestant[v - 1]--;
            if(AGagne()) this.Timer.Stop();
            Sauvegarde.Sauvegarder(this);
            return true;
        }

        //Donne un indice et retourne sa positon avec sa valeur
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

        //Retourne une suite aleatoire de [debut;fin[
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
        //Supprime tous les element lié
        public void Dispose()
        {
            this.Timer.Stop();
            this.Timer.Dispose();
        }
    }

    //Case du sudoku
    public class Case
    {
        public int Solution { get; protected set; }
        public int Taille;
        public bool[] Notes;
        public bool Indice;
        public int Valeur;

        public Case(int Taille, int Solution,bool Indice = false)
        {
            this.Solution = Solution;
            this.Valeur = Indice ? Solution : 0;
            this.Indice = Indice;
            this.Taille = Taille;
            this.Notes = new bool[Indice ? 0 : Taille];
        }

        //Retourne si la valeur dans la case est la bonne valeur
        public bool EstValide()
        {
            return this.Valeur == this.Solution;
        }

        //Retourne si c'est un indice
        public bool EstUnIndice()
        {
            return Indice;
        }

        //Retourne si la case est jouable, c'est a dire vide + n'est pas un indice
        public bool EstJouable()
        {
            return !this.EstUnIndice() && this.EstVide();
        }

        //Efface les notes lié a la case
        public void EffacerNotes()
        {
            for(int i = 0; i < this.Notes.Length; i++)
            {
                this.Notes[i] = false;
            }
        }
        //Retourne si la case est vide
        public bool EstVide()
        {
            return this.Valeur == 0;
        }
    }
}
