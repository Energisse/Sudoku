using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Sodoku
{
    public partial class Fsodoku : Form
    {
        private static Color colorSelection = Color.FromArgb(255, 170, 203, 255);
        int[,] grid = new int[9, 9];
        int[,] gridSolution = new int[9, 9];
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
                    dvg_motus.Rows[y].Cells[x].Style.SelectionBackColor = colorSelection;
                    dvg_motus.Rows[y].Cells[x].Style.SelectionForeColor = Color.Black;

                }
            }
            dvg_motus.CurrentCell.Selected = false;
            this.dvg_motus.CurrentCellChanged += new System.EventHandler(this.dvg_motus_CurrentCellChanged);

            afficher();
            start();
        }
        private void afficher()
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    /*int yAbsolue = y / 3;
                    //On se deplace de 3 case quand on a passé un bloc de 3*3 
                    //Afin de d'avoir un x en diagonale
                    int xAbsolue = x / 3 + yAbsolue;
                    //Tout les 2 bloc 3*3 on leur attribut un fond differents
                    if (xAbsolue % 2 == 0)
                    {
                        dvg_motus.Rows[y].Cells[x].Style.BackColor = Color.FromArgb(255, 191, 212, 245);
                    }
                    else
                    {*/
                    dvg_motus.Rows[y].Cells[x].Style.BackColor = Color.FromArgb(255, 255, 255, 255);

                    /* }*/
                }
            }

            //Si aucune case n'est selectionnée
            if (dvg_motus.CurrentCell.Selected == false) return;

            int posX = dvg_motus.CurrentCellAddress.X;
            int posY = dvg_motus.CurrentCellAddress.Y;

            /*COLORIAGE DES AXES X(9*1) ET Y(1*9) DE LA CASE SELECTIONNEE*/
            for (int i = 0; i < 9; i++)
            {
                dvg_motus.Rows[posY].Cells[i].Style.BackColor = Color.FromArgb(255, 225, 225, 225);
                dvg_motus.Rows[i].Cells[posX].Style.BackColor = Color.FromArgb(255, 225, 225, 225);
            }


            /*COLORIAGE DU BLOC DE 3*3 DE LA CASE SELECTIONNEE*/
            int yAbsolue = (posY / 3) * 3;
            int xAbsolue = (posX / 3) * 3;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    dvg_motus.Rows[y + yAbsolue].Cells[x + xAbsolue].Style.BackColor = Color.FromArgb(255, 225, 225, 225);
                }
            }

            /*COLORIAGE DE TOUTES LES CASES AYANT LE MEME NOMBRE QUE CELUI SELECTIONNEE*/
            String nombre = dvg_motus.Rows[posY].Cells[posX].Value.ToString();
            if (nombre != "")
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (dvg_motus.Rows[y].Cells[x].Value.ToString().Equals(nombre))
                        {
                            dvg_motus.Rows[y].Cells[x].Style.BackColor = colorSelection;
                        }
                    }
                }
            }
        }

        private void start()
        {

            this.solve(grid);
            gridSolution = (int[,])grid.Clone();

            int[] nombres = new int[81];
            for (int x = 0; x < 81; x++)
            {
                nombres[x] = x;
            }
            foreach (int i in randomizeArray(nombres))
            {

                int x = i % 9;
                int y = i / 9;

                int temp = grid[x, y];
                grid[x, y] = 0;
                int[,] copie = (int[,])grid.Clone();

                if (this.solveCount(copie, 0, 0) == 2)
                {
                    grid[x, y] = temp;
                }
            }


            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    dvg_motus.Rows[y].Cells[x].Value = grid[x, y] != 0 ? "" + grid[x, y] : "";
                }
            }

        }

        private bool solve(int[,] a, int x = 0, int y = 0)
        {
            if (y == 9) return true;
            if (x == 9) return solve(a, 0, y + 1);
            if (a[x, y] != 0) return solve(a, x + 1, y);
            int[] nombres = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in randomizeArray(nombres)) {
                if (nestPasDansLaLigne(i, x, y) && nestPasDansLaColonne(i, x, y) && controleInterieurCarre(i, x, y))
                {
                    a[x, y] = i;
                    if (solve(a, x + 1, y)) return true;
                    a[x, y] = 0;
                }
            }
            return false;
        }

        private int solveCount(int[,] grid, int x, int y)
        {
            if (y == 9) return 1;
            if (x == 9) return solveCount(grid, 0, y + 1);
            if (grid[x, y] != 0) return solveCount(grid, x + 1, y);
            int possibilite = 0;

            int[] nombres = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in randomizeArray(nombres))
            {
                if (nestPasDansLaLigne(i, x, y) && nestPasDansLaColonne(i, x, y) && controleInterieurCarre(i, x, y))
                {
                    grid[x, y] = i;
                    possibilite += solveCount(grid, x + 1, y);
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

        private bool controleInterieurCarre(int valeur, int x, int y)
        {
            int colonneAbsolue = ((int)x / 3) * 3;
            int ligneAbsolue = ((int)y / 3) * 3;
            for (int colonne = colonneAbsolue; colonne < colonneAbsolue + 3; colonne++)
            {
                for (int ligne = ligneAbsolue; ligne < ligneAbsolue + 3; ligne++)
                {
                    if (grid[colonne, ligne] == valeur) return false;
                }
            }
            return true;
        }
        public static int[] randomizeArray(int[] nombres)
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
        private void dvg_motus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start();
        }


        private void dvg_motus_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Si aucune case n'est selectionnée
            if (dvg_motus.CurrentCell.Selected == false) return;

            int x = dvg_motus.CurrentCellAddress.X;
            int y = dvg_motus.CurrentCellAddress.Y;
            //if()
            System.Diagnostics.Debug.WriteLine((int)e.KeyChar);

            //Si effacement de la case
            if ((int)e.KeyChar == 8)
            {
                //On regarde si la case n'est pas une indication
                if (grid[x, y] == 0)
                {
                    dvg_motus.Rows[y].Cells[x].Value = "";
                    dvg_motus.CurrentCell.Style.SelectionBackColor = colorSelection;
                    dvg_motus.CurrentCell.Style.SelectionForeColor = Color.Black;
                }
                afficher();
                return;
            }
            //System.Diagnostics.Debug.WriteLine();

            //On prends uniquement les chiffre de 1 a 9
            //Ascii code des nombres [1;9] = [49;57]
            if ((int)e.KeyChar < 49 || (int)e.KeyChar > 57) return;

            if (dvg_motus.Rows[y].Cells[x].Value.ToString().Equals(""))
            {
                dvg_motus.Rows[y].Cells[x].Value = e.KeyChar.ToString();
                if (gridSolution[x, y].ToString() != e.KeyChar.ToString())
                {
                    dvg_motus.Rows[y].Cells[x].Style.ForeColor = Color.FromArgb(255, 255, 0, 0);

                    dvg_motus.CurrentCell.Style.SelectionBackColor = Color.Red;
                    dvg_motus.CurrentCell.Style.SelectionForeColor = Color.White;
                }
                else
                {
                    dvg_motus.Rows[y].Cells[x].Style.ForeColor = Color.FromArgb(255, 0, 0, 255);
                }
                afficher();
            }
        }
        private void dvg_motus_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x< 9; x+=3)
            {
                for (int y = 0; y< 9; y+=3)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(new Point(y * 50, x * 50), new Size(150,150)));
                }
            }

        }

        private void dvg_motus_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dvg_motus_CurrentCellChanged(object sender, EventArgs e)
        {
            afficher();

        }
    }
}
