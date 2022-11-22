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
        public int taille { get; private set; }
        //Largeur du groupe ex : Une grille 9*9 a 9 groupes de 3*3 de largeur 3, une grille 12*12 a 12 groupes de 4*3 de largeur 4
        public int largeurGroupe { get; private set; }
        //Hauteur du groupe ex : Une grille 9*9 a 9 groupes de 3*3 de hauteur 3, une grille 12*12 a 12 groupes de 4*3 de hauteur 3
        public int hauteurGroupe { get; private set; }
        private int[,] grilleIndice;
        public int[,] grille { get; private set; }
        public int[,,] grilleNote { get; private set; }
        public int[,] grilleSolution {  get; private set; }
        public int vieRestante { get; private set; } 
        public int indiceRestant { get; private set; } 

        private int caseRestante;
        private int niveau;

        public Sudoku(int taille = 9, Difficulte niveau = Difficulte.Facile, int vie = 3, int indice = 3)
        {
            this.taille = taille;
            this.caseRestante = taille * taille;
            this.niveau = (int)niveau;

            int a = (int)Math.Truncate(Math.Sqrt(taille));

            while(a > 0)
            {
                if ((int)(taille / a) == (taille / (double)a)) break;
                a--;
            }
            System.Diagnostics.Debug.WriteLine(taille);

            this.hauteurGroupe = a;
            this.largeurGroupe = taille/ hauteurGroupe;
    
            this.vieRestante = vie;
            this.indiceRestant = indice;
            grilleNote = new int[taille, taille, taille];
            
            //Création de la grille a partir d'une grille vide
            grilleSolution = new int[taille, taille];
            resoudre(grilleSolution);
        
            //Création de la grille des indices
            grilleIndice = (int[,])grilleSolution.Clone();

            int suppresion = 0;
            int iteration = 0;
            //AMERLIORER LA SUPPRESSION DES CHIFFRES
            foreach (int i in suiteAleatoire(0, taille*taille))
            {
                int x = i % taille;
                int y = i / taille;
                int temp = grilleIndice[x, y];
                grilleIndice[x, y] = 0;
                int[,] copie = (int[,])grilleIndice.Clone();

                if (this.resoudreCompteur(copie, 0, 0) >= 2)
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
            grille = (int[,])grilleIndice.Clone();
            for (int x = 0; x < taille; x++)
            {
                for (int y = 0; y < taille; y++)
                {
                    if (grille[x, y] != 0)
                    {
                        caseRestante--;
                    }
                }
            }

        }

        public bool estMort()
        {
            return vieRestante == 0;
        }

        public bool aGagne()
        {
            return caseRestante == 0;
        }

        public bool caseEstUnIndice(int x, int y)
        {
            return grilleIndice[x, y] != 0;
        }

        public bool caseEstValide(int v, int x, int y)
        {
            return grilleSolution[x, y] == v;
        }
        public bool resoudre(int[,] grille, int x = 0, int y = 0)
        {
            if (y == taille) return true;
            if (x == taille) return resoudre(grille, 0, y + 1);
            if (grille[x, y] != 0) return resoudre(grille, x + 1, y);
            for (int i = 1; i <= taille; i++)
            {
                if (nestPasDansLaLigne(grille,i, x, y) && nestPasDansLaColonne(grille,i, x, y) && controleInterieurCarre(grille,i, x, y))
                {
                    grille[x, y] = i;
                    if (resoudre(grille, x + 1, y)) return true;
                    grille[x, y] = 0;
                }
            }
            return false;
        }

        private int resoudreCompteur(int[,] grille, int x, int y)
        {
            if (y == taille) return 1;
            if (x == taille) return resoudreCompteur(grille, 0, y + 1);
            if (grille[x, y] != 0) return resoudreCompteur(grille, x + 1, y);
            int possibilite = 0;

            for (int i = 1; i <= taille; i++)
            {
                if (nestPasDansLaLigne(grille,i, x, y) && nestPasDansLaColonne(grille,i, x, y) && controleInterieurCarre(grille,i, x, y))
                {
                    grille[x, y] = i;
                    possibilite += resoudreCompteur(grille, x + 1, y);
                    if (possibilite >= 2) return possibilite;
                    grille[x, y] = 0;
                }
            }
            return possibilite;
        }

        private bool nestPasDansLaLigne(int[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < taille; i++)
            {
                if (grille[i, y] == valeur) return false;
            }
            return true;
        }

        private bool nestPasDansLaColonne(int[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < taille; i++)
            {
                if (grille[x, i] == valeur) return false;
            }
            return true;
        }

        private bool controleInterieurCarre(int[,] grille, int valeur, int x, int y)
        {

            int colonneAbsolue = (x / this.largeurGroupe) * this.largeurGroupe;
            int ligneAbsolue = (y / this.hauteurGroupe) * this.hauteurGroupe;
            for (int colonne = colonneAbsolue; colonne < colonneAbsolue + this.largeurGroupe; colonne++)
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
            if (estMort()) return;
            for (int z = 0; z < taille; z++)
            {
                grilleNote[x, y, z] = 0;
            }
        }

        public void Noter(int v, int x, int y)
        {
            if (estMort()) return;
            grilleNote[x, y, v-1] = grilleNote[x, y, v - 1] == 0 ? v : 0;
        }

        public void Effacer(int x, int y)
        {
            if (estMort()) return;
            if (!caseEstUnIndice(x, y))
            {
                if (caseEstValide(grille[x, y], x, y))
                {
                    caseRestante++;
                }
                grille[x, y] = 0;
            }
        }

        public bool Jouer(int v, int x, int y)
        {
            if (estMort()) return false;
            System.Diagnostics.Debug.WriteLine(grille[x, y] + " " + x + " " + y + " " + v);

            if (grille[x, y] != 0) return true;
            grille[x, y] = v;
            if (!caseEstValide(v, x, y))
            {
                /*La case joué n'est pas bonne*/
                vieRestante--;
                return false;
            }
            /*La case joué est bonne*/
            caseRestante--;
            return true;
        }

        public (int x, int y) Indice()
        {
            if (indiceRestant == 0 || vieRestante == 0) return (-1, -1);
            //On parcours le tableau de facon aléatoire
            foreach (int x in suiteAleatoire(0, taille))
            {
                foreach (int y in suiteAleatoire(0, taille))
                {
                    //On applique un indice uniquement au cases fause ou non remplise
                    if (caseEstUnIndice(x, y)) continue;
                    if (grille[x, y] == grilleSolution[x, y]) continue;
                    Jouer(grilleSolution[x, y], x, y);
                    indiceRestant--;
                    return (x, y);
                }
            }
            return (-1,-1);
        }

        private static int[] suiteAleatoire(int debut, int fin)
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
                int value = liste[k];
                liste[k] = liste[i];
                liste[i] = value;
            }
            return liste;
        }
    }
}
