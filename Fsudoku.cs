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
using System.CodeDom;

namespace Sodoku
{
    public partial class Fsodoku : Form
    {
        private Sudoku sudoku;
        private static Color couleurSelection = Color.FromArgb(255, 170, 203, 255);
        private static Color couleurVoisin = Color.FromArgb(255, 225, 225, 225);
        private bool notes = false;
        private int nbrCase;

        //case courrante où le joueur joue
        //(contrainte car la grille peut être supperieur a 9x9 donc certains nombres s'ecrivent sur 2 chiffres,
        //on enregistre la valeur avant de la valider si le curseur est deplacé ou le jouer a appuyé sur "Entrée") [x,y,valeur]
        private Tuple<int, int, int> caseCourante = null;
        public Fsodoku(int taille = 9, Difficulte niveau = Difficulte.Facile, int vie = 3, int indice = 3)
        {
            InitializeComponent();
            this.nbrCase = taille;
            this.sudoku = new Sudoku(taille, niveau, vie, indice);
        }

        private void Init()
        {
            this.Width = (nbrCase > 9 ? nbrCase :9 )  * 50 + this.Padding.Right + this.Padding.Left;
            this.Height =  nbrCase * 50 + 250;
            dvg_motus.Width = nbrCase * 50 +2;
            dvg_motus.Height = nbrCase * 50 +2;
            dvg_motus.Location = new Point(this.Width/2- dvg_motus.Width/2, dvg_motus.Location.Y);
            gb_header.Location = new Point(this.Width / 2 - gb_header.Width / 2, gb_header.Location.Y);
            gb_bts.Location = new Point(this.Width / 2 - gb_bts.Width / 2, dvg_motus.Location.Y + dvg_motus.Height + 10);
            
            dvg_motus.RowCount = nbrCase;
            dvg_motus.ColumnCount = nbrCase;
         
            for (int x = 0; x < nbrCase; x++)
            {
                dvg_motus.Columns[x].Width = 50;
                for (int y = 0; y < nbrCase; y++)
                {
                    dvg_motus.Rows[y].Height = 50;
                    dvg_motus.Rows[y].Cells[x].Value = "";
                    dvg_motus.Rows[y].Cells[x].Style = null;
                }
            }
            for (int i = 0; i < this.nbrCase; i++)
            {
                Button bouton = new Button();
                bouton.Text = (1 + i).ToString();
                bouton.Font = new Font("Microsoft Sans Serif", (i + 1) >= 10 ? 15 : 22, FontStyle.Bold);
                bouton.Margin = new Padding(3);
                bouton.Width = 44;
                bouton.Height = 44;
                bouton.TextAlign = ContentAlignment.MiddleCenter;
                bouton.Click += new System.EventHandler(this.Bts_nb_click);
                bouton.Location = new Point(dvg_motus.Location.X + i * 50 + 3, dvg_motus.Location.Y + nbrCase * 50 + 75);
                this.Controls.Add(bouton);
            }
            this.dvg_motus.CurrentCellChanged += new System.EventHandler(this.Dvg_motus_CurrentCellChanged);
            Afficher();
            Start();
        }
        private void WindowsSodoku_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Afficher()
        {
            for (int x = 0; x < nbrCase; x++)
            {
                for (int y = 0; y < nbrCase; y++)
                {
                    dvg_motus.Rows[y].Cells[x].Style.BackColor = Color.White;
                }
            }

            //Si aucune case n'est selectionnée
            if (dvg_motus.CurrentCell != null && dvg_motus.CurrentCell.Selected == false ) return;

            int posX = dvg_motus.CurrentCellAddress.X;
            int posY = dvg_motus.CurrentCellAddress.Y;

            if (posY == -1 || posX ==-1 || posY >= nbrCase || posX >= nbrCase) return;


            /*COLORIAGE DES AXES X ET Y DE LA CASE SELECTIONNEE*/
            for (int i = 0; i < nbrCase; i++)
            {
                dvg_motus.Rows[posY].Cells[i].Style.BackColor = couleurVoisin;
                dvg_motus.Rows[i].Cells[posX].Style.BackColor = couleurVoisin;
            }


            /*COLORIAGE DU BLOC DE x*x DE LA CASE SELECTIONNEE*/
            int yAbsolue = (posY / sudoku.hauteurGroupe) * sudoku.hauteurGroupe;
            int xAbsolue = (posX / sudoku.largeurGroupe) * sudoku.largeurGroupe;
            for (int x = 0; x < sudoku.largeurGroupe; x++)
            {
                for (int y = 0; y < sudoku.hauteurGroupe; y++)
                {
                    //Utilisation du try pour eviter un bug d'indice lors du changement de taille
                    try
                    {
                        dvg_motus.Rows[y + yAbsolue].Cells[x + xAbsolue].Style.BackColor = couleurVoisin;
                    }
                    catch (Exception e)
                    {
                        break;
                    }
                }
            }

            /*COLORIAGE DE TOUTES LES CASES AYANT LE MEME NOMBRE QUE CELUI SELECTIONNEE*/
            String nombre = dvg_motus.Rows[posY].Cells[posX].Value.ToString();

            if (nombre != "")
            {
                for (int x = 0; x < nbrCase; x++)
                {
                    for (int y = 0; y < nbrCase; y++)
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
            for (int x = 0; x < nbrCase; x++)
            {
                for (int y = 0; y < nbrCase; y++)
                {
                    dvg_motus.Rows[y].Cells[x].Style = null ;
                }

            }
            AfficherGrille();
            timerLb.Reset();
            timerLb.Start();
        }
        private void dvg_motus_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                e.Handled = true;
            }
            return;
        }

        private void Dvg_motus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si la partie est fini
            if (sudoku.estMort()) return;

            if ((int)e.KeyChar == 13)
            {
                this.Appliquer_Action();
                return;
            }

            //Si aucune case n'est selectionnée
            if (dvg_motus.CurrentCell.Selected == false) return;

            int x = dvg_motus.CurrentCellAddress.X;
            int y = dvg_motus.CurrentCellAddress.Y;

            //Si effacement de la case
            if ((int)e.KeyChar == 8)
            {
                caseCourante = null;
                Effacer(x, y);
                AfficherGrille();
                return;
            }

            //On prends uniquement les chiffre de 0 a 9
            //Ascii code des nombres [0;9] = [48;57]
            if ((int)e.KeyChar < 48 || (int)e.KeyChar > 57) return;
            int valeurCourante = Int16.Parse((caseCourante == null ? "0" : caseCourante.Item3.ToString())+ e.KeyChar);
            if (valeurCourante <= 0 || valeurCourante > nbrCase) return;
            caseCourante = new Tuple<int, int, int>(x, y, valeurCourante);
            AfficherGrille();
        }
        private void Dvg_motus_Paint(object sender, PaintEventArgs e)
        {
           int largeur = (int)Math.Ceiling(Math.Sqrt(nbrCase));
           int hauteur = (int)Math.Floor(Math.Sqrt(nbrCase));
           int police = 30 / largeur;
           for (int x = 0; x < nbrCase; x ++)
            {
                for (int y = 0; y < nbrCase; y ++)
                {
                    if (sudoku.grille[x,y] != 0) continue;
                    for(int z = 0; z < nbrCase; z++)
                    {
                        if (sudoku.grilleNote[x,y,z] != 0)
                        {
                            e.Graphics.DrawString(sudoku.grilleNote[x, y, z].ToString(), new Font("Arial", police, FontStyle.Bold), Brushes.Gray, x * 50 + (z % largeur) * 50 / largeur, y * 50 + (z / largeur) * 50 / largeur);
                        }
                    }
                }
            }
            if (caseCourante != null && notes == true)
            {
                System.Diagnostics.Debug.WriteLine(sudoku.grilleNote[caseCourante.Item1, caseCourante.Item2, caseCourante.Item3 - 1]);

                bool effacement = sudoku.grilleNote[caseCourante.Item1, caseCourante.Item2, caseCourante.Item3 - 1] == 1;
                Brush brush = effacement ? new SolidBrush(couleurSelection): new SolidBrush(Color.Gray);
                e.Graphics.DrawString(caseCourante.Item3.ToString(), new Font("Arial", police, FontStyle.Bold), brush, caseCourante.Item1 * 50 + ((caseCourante.Item3 - 1) % largeur) * 50 / largeur, caseCourante.Item2 * 50 + ((caseCourante.Item3 - 1) / largeur) * 50 / largeur);
                
            }

            for (int x = 0; x< nbrCase; x+=sudoku.largeurGroupe)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2),x*50,0,x*50,nbrCase*50);
            }
            for (int y = 0; y < nbrCase; y += sudoku.hauteurGroupe)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2),0,y * 50, nbrCase * 50, y * 50);
            }

        }

        private void Dvg_motus_CurrentCellChanged(object sender, EventArgs e)
        {
            Afficher();
        }

        private void Bt_rejouer_Click(object sender, EventArgs e)
        {
            Start();
            var frm = new FMenu();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Dispose();
        }

        private void AfficherGrille()
        {
            if (sudoku == null) return;
            if (sudoku.estMort())
            {
                timerLb.Stop();
                MessageBox.Show("Et c'est perdu", "Perdu");
                for (int x = 0; x < nbrCase; x++)
                {
                    for (int y = 0; y < nbrCase; y++)
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
                timerLb.Stop();
                MessageBox.Show("Et c'est gagné", "Gagné");
            }
            else
            {
                for (int x = 0; x < nbrCase; x++)
                {
                    for (int y = 0; y < nbrCase; y++)
                    {
                        dvg_motus.Rows[y].Cells[x].Value = sudoku.grille[x, y] != 0 ? sudoku.grille[x, y].ToString() : "";
                    }
                }
                if (caseCourante != null && notes == false)
                {

                    dvg_motus.Rows[caseCourante.Item2].Cells[caseCourante.Item1].Value = caseCourante.Item3;
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
            this.Appliquer_Action();
            notes = !notes;
            bt_notes.BackColor = notes ? Color.Blue : Color.White;
        }

        private void Placer(int v, int x, int y)
        {
            if (notes)
            {
                System.Diagnostics.Debug.WriteLine("Note " + v + " a " + x + " " + y);

                sudoku.Noter(v, x, y);
            }
            else if (sudoku.Jouer(v, x, y))
            {
                dvg_motus.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
            }
            else
            {
                dvg_motus.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                dvg_motus.Rows[y].Cells[x].Style.SelectionBackColor = Color.Red;
                dvg_motus.Rows[y].Cells[x].Style.SelectionForeColor = Color.White;
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

        private void Appliquer_Action()
        {
            if (caseCourante == null) return;
            Placer(caseCourante.Item3, caseCourante.Item1, caseCourante.Item2);
            caseCourante = null;
        }

        private void dvg_motus_SelectionChanged(object sender, EventArgs e)
        {
            this.Appliquer_Action();
        }

       
    }

   
}
