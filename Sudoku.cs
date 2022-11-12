using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodoku
{
    internal class Sudoku
    {
        private int[,] grille = new int[9, 9];
        private int[,] grilleSolution = new int[9, 9];

        public void genererGrille()
        {
            this.resoudre(grille);
            grilleSolution = (int[,])grille.Clone();

            int[] nombres = new int[81];
            for (int x = 0; x < 81; x++)
            {
                nombres[x] = x;
            }

            //AMERLIORER LA SUPPRESSION DES CHIFFRES
            foreach (int i in randomizeArray(nombres))
            {
                int x = i % 9;
                int y = i / 9;

                int temp = grille[x, y];
                grille[x, y] = 0;
                int[,] copie = (int[,])grille.Clone();

                if (this.resoudreCompteur(copie, 0, 0) == 2)
                {
                    grille[x, y] = temp;
                }
            }
        }

        public int[,] getGrille()
        {
            return grille;
        }

        public bool caseEstUnIndice(int x, int y)
        {
            return grille[x, y] != 0;
        }

        public bool caseEstValide(string v, int x, int y)
        {
            return grilleSolution[x, y].ToString() == v;

        }

        public bool resoudre(int[,] a, int x = 0, int y = 0)
        {
            if (y == 9) return true;
            if (x == 9) return resoudre(a, 0, y + 1);
            if (a[x, y] != 0) return resoudre(a, x + 1, y);
            int[] nombres = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in randomizeArray(nombres))
            {
                if (nestPasDansLaLigne(i, x, y) && nestPasDansLaColonne(i, x, y) && controleInterieurCarre(i, x, y))
                {
                    a[x, y] = i;
                    if (resoudre(a, x + 1, y)) return true;
                    a[x, y] = 0;
                }
            }
            return false;
        }

        private int resoudreCompteur(int[,] grid, int x, int y)
        {
            if (y == 9) return 1;
            if (x == 9) return resoudreCompteur(grid, 0, y + 1);
            if (grid[x, y] != 0) return resoudreCompteur(grid, x + 1, y);
            int possibilite = 0;

            int[] nombres = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in randomizeArray(nombres))
            {
                if (nestPasDansLaLigne(i, x, y) && nestPasDansLaColonne(i, x, y) && controleInterieurCarre(i, x, y))
                {
                    grid[x, y] = i;
                    possibilite += resoudreCompteur(grid, x + 1, y);
                    if (possibilite == 2) return possibilite;
                    grid[x, y] = 0;
                }
            }
            return possibilite;
        }

        private bool nestPasDansLaLigne(int valeur, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grille[i, y] == valeur) return false;
            }
            return true;
        }

        private bool nestPasDansLaColonne(int valeur, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grille[x, i] == valeur) return false;
            }
            return true;
        }

        private bool controleInterieurCarre(int valeur, int x, int y)
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

        private static int[] randomizeArray(int[] nombres)
        {
            Random rnd = new Random();

            for (int i = nombres.Length - 1; i >= 0; i--)
            {
                int k = rnd.Next(0, 8);
                int value = nombres[k];
                nombres[k] = nombres[i];
                nombres[i] = value;
            }
            return nombres;
        }
    }
}
