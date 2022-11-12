using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodoku
{
    internal class Sudoku
    {
        private int[,] grilleIndice = new int[9, 9];
        public int[,] grille { get; private set; } = new int[9, 9];
        private int[,,] grilleNote = new int[9, 9, 9];
        public int[,] grilleSolution {  get; private set; } = new int[9, 9];
        public int vieRestante { get; private set; } = 3;
        public int indiceRestant { get; private set; } = 3;
        private int caseRestante  = 81;

        public void genererGrille()
        {
            vieRestante = 3;
            indiceRestant = 3;
            grilleNote = new int[9, 9, 9];
            grilleIndice = new int[9, 9];
            resoudre(grilleSolution);
            grilleIndice = (int[,])grilleSolution.Clone();
            caseRestante = 81;
            //AMERLIORER LA SUPPRESSION DES CHIFFRES
            foreach (int i in suiteAleatoire(0,80))
            {
                int x = i % 9;
                int y = i / 9;
                System.Diagnostics.Debug.WriteLine(x +" " + y);
                int temp = grilleIndice[x, y];
                grilleIndice[x, y] = 0;
                int[,] copie = (int[,])grilleIndice.Clone();

                if (this.resoudreCompteur(copie, 0, 0) >= 2)
                {
                    grilleIndice[x, y] = temp;
                }
            }
            grille = (int[,])grilleIndice.Clone();
            for(int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (grille[x,y] != 0)
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
            if (y == 9) return true;
            if (x == 9) return resoudre(grille, 0, y + 1);
            if (grille[x, y] != 0) return resoudre(grille, x + 1, y);
            foreach (int i in suiteAleatoire(1, 10))
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
            if (y == 9) return 1;
            if (x == 9) return resoudreCompteur(grille, 0, y + 1);
            if (grille[x, y] != 0) return resoudreCompteur(grille, x + 1, y);
            int possibilite = 0;

            foreach (int i in suiteAleatoire(1,10))
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
            for (int i = 0; i < 9; i++)
            {
                if (grille[i, y] == valeur) return false;
            }
            return true;
        }

        private bool nestPasDansLaColonne(int[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grille[x, i] == valeur) return false;
            }
            return true;
        }

        private bool controleInterieurCarre(int[,] grille,  int valeur, int x, int y)
        {
            int colonneAbsolue = (x / 3) * 3;
            int ligneAbsolue = (y / 3) * 3;
            for (int colonne = colonneAbsolue; colonne < colonneAbsolue + 3; colonne++)
            {
                for (int ligne = ligneAbsolue; ligne < ligneAbsolue + 3; ligne++)
                {
                    if (grille[colonne, ligne] == valeur) return false;
                }
            } 
            return true;
        }

        public bool jouer(int v, int x, int y)
        {
            if (estMort()) return false;
            if(v == 0)
            {
                if (!caseEstUnIndice(x, y))
                {
                    if(caseEstValide(grille[x, y], x, y))
                    {
                        caseRestante++; 
                    }
                    grille[x, y] = 0;
                }
                return true;
            };
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
            foreach (int x in suiteAleatoire(0,9))
            {
                foreach (int y in suiteAleatoire(0, 9))
                {
                    //On applique un indice uniquement au cases fause ou non remplise
                    if (caseEstUnIndice(x, y)) continue;
                    if (grille[x, y] == grilleSolution[x, y]) continue;
                    jouer(grilleSolution[x, y], x, y);
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
