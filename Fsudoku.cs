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
        private bool notes = false;

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
                    dvg_motus.Rows[y].Cells[x].Style = null;
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

            lb_vie.Text = sudoku.vieRestante.ToString();
            lb_indice.Text = sudoku.indiceRestant.ToString();
        }

        private void Start()
        {
            sudoku.genererGrille();
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    dvg_motus.Rows[y].Cells[x].Style = null ;
                }
            }
            AfficherGrille();
        }

        private void Dvg_motus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si la partie est fini
            if (sudoku.estMort()) return;
            //Si aucune case n'est selectionnée
            if (dvg_motus.CurrentCell.Selected == false) return;

            int x = dvg_motus.CurrentCellAddress.X;
            int y = dvg_motus.CurrentCellAddress.Y;

            //Si effacement de la case
            if ((int)e.KeyChar == 8)
            {
                Effacer(x,y);
                AfficherGrille();
                return;
            }

            //On prends uniquement les chiffre de 1 a 9
            //Ascii code des nombres [1;9] = [49;57]
            if ((int)e.KeyChar < 49 || (int)e.KeyChar > 57) return;
            dvg_motus.CurrentCell.Value = e.KeyChar.ToString();
            Placer((int)e.KeyChar - 48, x, y);
            AfficherGrille();
        }
        private void Dvg_motus_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < 9; x ++)
            {
                for (int y = 0; y < 9; y ++)
                {
                    if (sudoku.grille[x,y] != 0) continue;
                    for(int z = 0; z < 9; z++)
                    {
                        if (sudoku.grilleNote[x,y,z] != 0)
                        {
                            e.Graphics.DrawString(sudoku.grilleNote[x, y, z].ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Gray, x * 50 + (z % 3) * 16, y * 50 + (z / 3) * 16);
                        }
                    }
                }
            }

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

        private void AfficherGrille()
        {
            if (sudoku.estMort())
            {
                MessageBox.Show("Et c'est perdu", "Perdu");
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if(sudoku.grilleSolution[x, y] != sudoku.grille[x, y])
                        {
                            dvg_motus.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                        }
                        dvg_motus.Rows[y].Cells[x].Value = sudoku.grilleSolution[x, y].ToString();
                    }
                }
            }
            else if (sudoku.aGagne())
            {
                MessageBox.Show("Et c'est gagné", "Gagné");
            }
            else
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        dvg_motus.Rows[y].Cells[x].Value = sudoku.grille[x, y] != 0 ? sudoku.grille[x, y].ToString() : "";
                    }
                }

            }
            Afficher();
        }

        private void Bt_indice_Click(object sender, EventArgs e)
        {
            if (sudoku.estMort()) return;
            (int x, int y ) = sudoku.Indice();
            if (x == -1) return;
            dvg_motus.CurrentCell = dvg_motus.Rows[y].Cells[x];
            dvg_motus.CurrentCell.Style.ForeColor = Color.Blue;
            AfficherGrille();
        }

        private void Bt_notes_Click(object sender, EventArgs e)
        {
            notes = !notes;
            bt_notes.BackColor = notes ? Color.Blue : Color.White ;
        }

        private void Placer(int v, int x, int y)
        {

            if (notes)
            {
                sudoku.Noter(v, x, y);
            }
            else if (sudoku.Jouer(v, x, y))
            {
                dvg_motus.CurrentCell.Style.ForeColor = Color.Blue;
            }
            else
            {
                dvg_motus.CurrentCell.Style.ForeColor = Color.Red;
                dvg_motus.CurrentCell.Style.SelectionBackColor = Color.Red;
                dvg_motus.CurrentCell.Style.SelectionForeColor = Color.White;
            }
        }

        private void Effacer(int x, int y)
        {
            if (notes)
            {
                sudoku.EffacerNote(x, y);
            }
            else
            {
                sudoku.Effacer(x, y);
                dvg_motus.CurrentCell.Style.SelectionBackColor = couleurSelection;
                dvg_motus.CurrentCell.Style.SelectionForeColor = Color.Black;
            }
        }

        private void Bts_nb_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Placer(Int16.Parse(btn.Text.ToString()),dvg_motus.CurrentCell.ColumnIndex,dvg_motus.CurrentCell.RowIndex);
            AfficherGrille();
        }

        private void Bt_effacer_Click(object sender, EventArgs e)
        {
            Effacer(dvg_motus.CurrentCell.ColumnIndex, dvg_motus.CurrentCell.RowIndex);
            AfficherGrille();
        }
    }
}
