using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodoku
{
    public partial class Fsodoku : Form
    {
        int[,] grid = new int[9, 9];
        public Fsodoku()
        {
            InitializeComponent();
        }

        private void WindowsSodoku_Load(object sender, EventArgs e)
        {
            dvg_motus.RowCount = 9;
            dvg_motus.ColumnCount = 9;
            for (int x = 0; x < 9; x++)
            {
                dvg_motus.Columns[x].Width = 50;
                for (int y = 0; y < 9; y++)
                {
                    dvg_motus.Rows[y].Height = 50;

                }
            }

            this.solve(grid, 0,0);
            for(int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    dvg_motus.Rows[y].Cells[x].Value = grid[x, y];
                }
            }
        }
        private bool solve(int[,] grid,int x, int y) 
        {
            if (y == 9) return true;
            if (x == 9) return solve(grid,0, y + 1);
            if (grid[x,y] != 0) return solve(grid,x + 1,y);
            foreach (int i in nombreAleatoire())
            {
                System.Diagnostics.Debug.WriteLine("x=" + x + " y=" + y + " i= " + i + "   " + (nestPasDansLaLigne(i, x, y) && nestPasDansLaColonne(i, x, y) && controleInterieurCarre(i, x, y)));
                if (nestPasDansLaLigne(i, x, y) && nestPasDansLaColonne(i, x, y)  && controleInterieurCarre(i, x, y))
                {
                    grid[x, y] = i;
                    if (solve(grid,x + 1, y)) return true;
                    grid[x, y] = 0;
                }
            }
            return false;
        }


        private bool nestPasDansLaLigne(int valeur,int x, int y)
        {
            for(int i = 0; i < 9; i++)
            {
                if (grid[i, y] == valeur) return false;
            }
            return true;
        }

        private bool nestPasDansLaColonne(int valeur, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[x, i] == valeur) return false;
            }
            return true;
        }

        private bool controleInterieurCarre(int valeur,int x, int y)
        {
            int colonneAbsolue = ((int)x / 3) * 3;
            int ligneAbsolue = ((int)y / 3) * 3;
            for ( int colonne = colonneAbsolue; colonne < colonneAbsolue + 3; colonne++)
            {
                for (int ligne = ligneAbsolue; ligne < ligneAbsolue + 3; ligne++)
                {
                    if (grid[colonne, ligne] == valeur) return false;
                }
            }
            return true;
        }
        public static int[] nombreAleatoire()
        {
            int[] nombres = new int[9] {1,2,3,4,5,6,7,8,9};
            Random rnd = new Random();

            for (int i = 8; i>=0; i--)
            {
                int k = rnd.Next(0,8);
                int value = nombres[k];
                nombres[k] = nombres[i];
                nombres[i] = value;
            }
            return nombres;
         
        }
        private void dvg_motus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
