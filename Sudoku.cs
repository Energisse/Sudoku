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

namespace Sodoku
{

    public enum Difficulte : int
    {
        Facile = 4,
        Moyen = 3,
        Difficile = 2,
        Extreme = 1
    }
    internal class Sudoku
    {
        public int Taille { get; private set; }
        //Largeur du groupe ex : Une grille 9*9 a 9 groupes de 3*3 de largeur 3, une grille 12*12 a 12 groupes de 4*3 de largeur 4
        public int LargeurGroupe { get; private set; }
        //Hauteur du groupe ex : Une grille 9*9 a 9 groupes de 3*3 de hauteur 3, une grille 12*12 a 12 groupes de 4*3 de hauteur 3
        public int hauteurGroupe { get; private set; }
        private readonly int[,] grilleIndice;
        public int[,] Grille { get; private set; }
        public int[,,] GrilleNote { get; private set; }
        public int[,] GrilleSolution {  get; private set; }
        public int VieRestante { get; private set; } 
        public int IndiceRestant { get; private set; } 

        private int CaseRestante;
        private readonly int niveau;

        public Sudoku(int taille = 9, Difficulte niveau = Difficulte.Facile, int vie = 3, int indice = 3)
        {
            this.Taille = taille;
            this.CaseRestante = taille * taille;
            this.niveau = (int)niveau;

            int a = (int)Math.Truncate(Math.Sqrt(taille));

            while(a > 0)
            {
                if ((int)(taille / a) == (taille / (double)a)) break;
                a--;
            }
            System.Diagnostics.Debug.WriteLine(taille);

            this.hauteurGroupe = a;
            this.LargeurGroupe = taille/ hauteurGroupe;
    
            this.VieRestante = vie;
            this.IndiceRestant = indice;
            GrilleNote = new int[taille, taille, taille];
            
            //Création de la grille a partir d'une grille vide
            GrilleSolution = new int[taille, taille];
            Resoudre(GrilleSolution);
        
            //Création de la grille des indices
            grilleIndice = (int[,])GrilleSolution.Clone();

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
                else if (suppresion++ >= taille* taille/ this.niveau)
                {
                    System.Diagnostics.Debug.WriteLine("fin");

                    break;
                };
                System.Diagnostics.Debug.WriteLine(suppresion + " " + ((double)iteration++ / ((double)taille * taille))*100 + "%");

            }
            Grille = (int[,])grilleIndice.Clone();
            for (int x = 0; x < taille; x++)
            {
                for (int y = 0; y < taille; y++)
                {
                    if (Grille[x, y] != 0)
                    {
                        CaseRestante--;
                    }
                }
            }

        }

        public bool EstMort()
        {
            return VieRestante == 0;
        }

        public bool AGagne()
        {
            return CaseRestante == 0;
        }

        public bool CaseEstUnIndice(int x, int y)
        {
            return grilleIndice[x, y] != 0;
        }

        public bool CaseEstValide(int v, int x, int y)
        {
            return GrilleSolution[x, y] == v;
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
            int ligneAbsolue = (y / this.hauteurGroupe) * this.hauteurGroupe;
            for (int colonne = colonneAbsolue; colonne < colonneAbsolue + this.LargeurGroupe; colonne++)
            {
                for (int ligne = ligneAbsolue; ligne < ligneAbsolue + this.hauteurGroupe; ligne++)
                {
                    if (grille[colonne, ligne] == valeur) return false;
                }
            }
            return true;
        }

        public void EffacerNote(int x, int y)
        {
            if (EstMort()) return;
            for (int z = 0; z < Taille; z++)
            {
                GrilleNote[x, y, z] = 0;
            }
        }

        public void Noter(int v, int x, int y)
        {
            if (EstMort()) return;
            GrilleNote[x, y, v-1] = GrilleNote[x, y, v - 1] == 0 ? v : 0;
        }

        public void Effacer(int x, int y)
        {
            if (EstMort()) return;
            if (!CaseEstUnIndice(x, y))
            {
                if (CaseEstValide(Grille[x, y], x, y))
                {
                    CaseRestante++;
                }
                Grille[x, y] = 0;
            }
        }

        public bool Jouer(int v, int x, int y)
        {
            if (EstMort()) return false;

            if (Grille[x, y] != 0) return true;
            Grille[x, y] = v;
            if (!CaseEstValide(v, x, y))
            {
                /*La case joué n'est pas bonne*/
                VieRestante--;
                return false;
            }
            /*La case joué est bonne*/
            CaseRestante--;
            return true;
        }

        public (int x, int y) Indice()
        {
            if (IndiceRestant == 0 || VieRestante == 0) return (-1, -1);
            //On parcours le tableau de facon aléatoire
            foreach (int x in SuiteAleatoire(0, Taille))
            {
                foreach (int y in SuiteAleatoire(0, Taille))
                {
                    //On applique un indice uniquement au cases fause ou non remplise
                    if (CaseEstUnIndice(x, y)) continue;
                    if (Grille[x, y] == GrilleSolution[x, y]) continue;
                    Jouer(GrilleSolution[x, y], x, y);
                    IndiceRestant--;
                    return (x, y);
                }
            }
            return (-1,-1);
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
    }
}
