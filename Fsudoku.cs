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

        private Sudoku sudoku = new Sudoku();
        private static Color couleurSelection = Color.FromArgb(255, 170, 203, 255);
        private static Color couleurVoisin = Color.FromArgb(255, 225, 225, 225);
        private int vie = 3;

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
                    dvg_motus.Rows[y].Cells[x].Style.SelectionBackColor = couleurSelection;
                    dvg_motus.Rows[y].Cells[x].Style.SelectionForeColor = Color.Black;

                }
            }
            dvg_motus.CurrentCell.Selected = false;
            this.dvg_motus.CurrentCellChanged += new System.EventHandler(this.Dvg_motus_CurrentCellChanged);

            Afficher();
            Start();
        }
        private void Afficher()
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
                        Dvg_motus.Rows[y].Cells[x].Style.BackColor = Color.FromArgb(255, 191, 212, 245);
                    }
                    else
                    {*/
                    dvg_motus.Rows[y].Cells[x].Style.BackColor = Color.White;

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
                dvg_motus.Rows[posY].Cells[i].Style.BackColor = couleurVoisin;
                dvg_motus.Rows[i].Cells[posX].Style.BackColor = couleurVoisin;
            }


            /*COLORIAGE DU BLOC DE 3*3 DE LA CASE SELECTIONNEE*/
            int yAbsolue = (posY / 3) * 3;
            int xAbsolue = (posX / 3) * 3;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    dvg_motus.Rows[y + yAbsolue].Cells[x + xAbsolue].Style.BackColor = couleurVoisin;
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
                            dvg_motus.Rows[y].Cells[x].Style.BackColor = couleurSelection;
                        }
                    }
                }
            }

            lb_vie.Text = vie.ToString();
        }

        private void Start()
        {
            vie = 3;
            sudoku.genererGrille();
            int[,] grille = sudoku.getGrille();

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    dvg_motus.Rows[y].Cells[x].Value = grille[x, y] != 0 ? "" + grille[x, y] : "";
                    dvg_motus.Rows[y].Cells[x].Style = null;
                }
            }
            Afficher();
        }

        private void Dvg_motus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si la partie est fini
            if (vie == 0) return;

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
                if (!sudoku.caseEstUnIndice(x, y))
                {
                    dvg_motus.CurrentCell.Value = "";
                    dvg_motus.CurrentCell.Style.SelectionBackColor = couleurSelection;
                    dvg_motus.CurrentCell.Style.SelectionForeColor = Color.Black;
                }
                Afficher();
                return;
            }
            //System.Diagnostics.Debug.WriteLine();

            //On prends uniquement les chiffre de 1 a 9
            //Ascii code des nombres [1;9] = [49;57]
            if ((int)e.KeyChar < 49 || (int)e.KeyChar > 57) return;

            if (dvg_motus.CurrentCell.Value.ToString().Equals(""))
            {
                dvg_motus.CurrentCell.Value = e.KeyChar.ToString();
                if (!sudoku.caseEstValide(e.KeyChar.ToString(),x,y))
                {
                    vie--;
                    dvg_motus.CurrentCell.Style.ForeColor = Color.Red;
                    dvg_motus.CurrentCell.Style.SelectionBackColor = Color.Red;
                    dvg_motus.CurrentCell.Style.SelectionForeColor = Color.White;
                }
                else
                {
                    dvg_motus.CurrentCell.Style.ForeColor = Color.Red;
                }
                Afficher();
            }
        }
        private void Dvg_motus_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x< 9; x+=3)
            {
                for (int y = 0; y< 9; y+=3)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(new Point(y * 50, x * 50), new Size(150,150)));
                }
            }

        }

        private void Dvg_motus_CurrentCellChanged(object sender, EventArgs e)
        {
            Afficher();
        }

        private void Bt_rejouer_Click(object sender, EventArgs e)
        {
            Start();
        }

     
    }
}
