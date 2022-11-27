﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodoku.Composants
{
    internal class Grille : DataGridView
    {
        private static readonly Color CouleurSelection = Color.FromArgb(255, 170, 203, 255);
        private static readonly Color CouleurVoisin = Color.FromArgb(255, 225, 225, 225);

        public int TailleCase = 50;
        public Sudoku _Sudoku = null;
        private bool _Note = false;
        public delegate void MyEventHandler();
        public event MyEventHandler onPlay;
        public bool Note
        {
            get { return _Note; }
            set { 
                _Note = value;
                this.Appliquer_Action();    
            }
        }
        public Sudoku Sudoku
        {
            get { return _Sudoku; }
            set { 
                _Sudoku = value;
                Init();
            }
        }

        private CaseCourante caseCourante = null;

        public Grille()
        {
            this.Font = new Font("Microsoft Sans Serif", 26);
        }

        private void Afficher()
        {
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    this.Rows[y].Cells[x].Style.BackColor = Color.White;
                }
            }

            //Si aucune case n'est selectionnée
            if (this.CurrentCell != null && this.CurrentCell.Selected == false) return;

            int posX = this.CurrentCellAddress.X;
            int posY = this.CurrentCellAddress.Y;

            if (posY == -1 || posX == -1 || posY >= Sudoku.Taille || posX >= Sudoku.Taille) return;


            /*COLORIAGE DES AXES X ET Y DE LA CASE SELECTIONNEE*/
            for (int i = 0; i < Sudoku.Taille; i++)
            {
                this.Rows[posY].Cells[i].Style.BackColor = CouleurVoisin;
                this.Rows[i].Cells[posX].Style.BackColor = CouleurVoisin;
            }


            /*COLORIAGE DU BLOC DE x*x DE LA CASE SELECTIONNEE*/
            int yAbsolue = (posY / Sudoku.HauteurGroupe) * Sudoku.HauteurGroupe;
            int xAbsolue = (posX / Sudoku.LargeurGroupe) * Sudoku.LargeurGroupe;
            for (int x = 0; x < Sudoku.LargeurGroupe; x++)
            {
                for (int y = 0; y < Sudoku.HauteurGroupe; y++)
                {
                    //Utilisation du try pour eviter un bug d'indice lors du changement de taille
                    try
                    {
                        this.Rows[y + yAbsolue].Cells[x + xAbsolue].Style.BackColor = CouleurVoisin;
                    }
                    catch (Exception e)
                    {
                        break;
                    }
                }
            }

            /*COLORIAGE DE TOUTES LES CASES AYANT LE MEME NOMBRE QUE CELUI SELECTIONNEE*/
            String nombre = this.Rows[posY].Cells[posX].Value.ToString();

            if (nombre != "")
            {
                for (int x = 0; x < Sudoku.Taille; x++)
                {
                    for (int y = 0; y < Sudoku.Taille; y++)
                    {
                        if (this.Rows[y].Cells[x].Value.ToString().Equals(nombre))
                        {
                            this.Rows[y].Cells[x].Style.BackColor = CouleurSelection;
                        }
                    }
                }
            }

        }
        public void Effacer(int x, int y)
        {
            if (_Note)
            {
                Sudoku.EffacerNote(x, y);
            }
            else
            {
                Sudoku.Effacer(x, y);
                this.CurrentCell.Style.SelectionBackColor = CouleurSelection;
                this.CurrentCell.Style.SelectionForeColor = Color.Black;
            }
        }

        private void AfficherGrille()
        {
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    this.Rows[y].Cells[x].Value = Sudoku.Grille[x, y] != 0 ? Sudoku.Grille[x, y].ToString() : "";
                }
            }
            if (caseCourante != null && _Note == false)
            {
                this.Rows[caseCourante.Y].Cells[caseCourante.X].Value = caseCourante.V;
            }
            Afficher();
        }
        private void Init()
        {
            if (Sudoku == null) return;

            this.RowCount = Sudoku.Taille;
            this.ColumnCount = Sudoku.Taille;

            for (int x = 0; x < Sudoku.Taille; x++)
            {
                this.Columns[x].Width = 50;
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    this.Rows[y].Height = 50;
                    this.Rows[y].Cells[x].Value = "";
                    this.Rows[y].Cells[x].Style = null;
                }
            }
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    this.Rows[y].Cells[x].Style = null;
                }
            }
            if (Sudoku.EstMort())
            {
                AfficherGrilleMort();
                return;
            }
                for (int x = 0; x < Sudoku.Taille; x++)
                {
                    for (int y = 0; y < Sudoku.Taille; y++)
                    {
                        if (!this.Sudoku.CaseEstUnIndice(x, y) && this.Sudoku.Grille[x, y] != 0)
                        {
                            if (this.Sudoku.CaseEstValide(this.Sudoku.Grille[x, y], x, y))
                            {
                                this.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
                            }
                            else
                            {
                                this.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                                this.Rows[y].Cells[x].Style.SelectionBackColor = Color.Red;
                                this.Rows[y].Cells[x].Style.SelectionForeColor = Color.White;
                            }
                        }
                    }
                }
            AfficherGrille();
        }
        private void AfficherGrilleMort()
        {
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    if (Sudoku.GrilleSolution[x, y] != Sudoku.Grille[x, y])
                    {
                        this.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                    }
                    else if (!Sudoku.CaseEstUnIndice(x,y) &&  Sudoku.GrilleSolution[x, y] == Sudoku.Grille[x, y])
                    {
                        this.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
                    }
                    this.Rows[y].Cells[x].Value = Sudoku.GrilleSolution[x, y].ToString();
                }
            }
        }

        public void Indice()
        {
            if (Sudoku.EstMort()) return;
            (int x, int y,int v) = Sudoku.Indice();
            if (x == -1) return;
            this.AfficherGrille();
            Placer(x, y, v);        
            this.Rows[y].Cells[x].Selected = true;
        }
        public void Placer(int x, int y, int v,bool noter = false)
        {
            if (noter)
            {
                Sudoku.Noter( x, y,v);
            }
            else
            {
                if (Sudoku.Jouer(x, y, v))
                {
                    this.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
                }
                else
                {
                    this.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                    this.Rows[y].Cells[x].Style.SelectionBackColor = Color.Red;
                    this.Rows[y].Cells[x].Style.SelectionForeColor = Color.White;
                }
                onPlay();
               if (Sudoku.EstMort())
               {
                   MessageBox.Show("Et c'est perdu", "Perdu");
                   AfficherGrilleMort();
                   return;
               }
               else if (Sudoku.AGagne())
               {
                   MessageBox.Show("Et c'est gagné", "Gagné");
               }
            }
            AfficherGrille();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Sudoku == null) return;
            int largeur = (int)Math.Ceiling(Math.Sqrt(Sudoku.Taille));
            int police = 30 / largeur;
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    if (Sudoku.Grille[x, y] != 0) continue;
                    for (int z = 0; z < Sudoku.Taille; z++)
                    {
                        if (Sudoku.GrilleNote[x, y, z] != 0)
                        {
                            e.Graphics.DrawString(Sudoku.GrilleNote[x, y, z].ToString(), new Font("Arial", police, FontStyle.Bold), Brushes.Gray, x * 50 + (z % largeur) * 50 / largeur, y * 50 + (z / largeur) * 50 / largeur);
                        }
                    }
                }
            }

            if (caseCourante != null && _Note == true)
            {
                bool effacement = Sudoku.GrilleNote[caseCourante.X, caseCourante.Y, caseCourante.V - 1] != 0;
                //Effacement en ecrivant de la couleur du fond
                Brush brush = effacement ? new SolidBrush(CouleurSelection) : new SolidBrush(Color.Gray);
                e.Graphics.DrawString(caseCourante.V.ToString(), new Font("Arial", police, FontStyle.Bold), brush, caseCourante.X * 50 + ((caseCourante.V - 1) % largeur) * 50 / largeur, caseCourante.Y * 50 + ((caseCourante.V - 1) / largeur) * 50 / largeur);

            }
            for (int x = 0; x < Sudoku.Taille; x += Sudoku.LargeurGroupe)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), x * 50, 0, x * 50, Sudoku.Taille * 50);
            }
            for (int y = 0; y < Sudoku.Taille; y += Sudoku.HauteurGroupe)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, y * 50, Sudoku.Taille * 50, y * 50);
            }
        }

        private void Appliquer_Action()
        {
            if (caseCourante == null) return;
            Placer(caseCourante.X, caseCourante.Y, caseCourante.V,this._Note);
            caseCourante = null;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //Si la partie est fini
            if (Sudoku.EstMort() || Sudoku.AGagne()) return;

            if ((int)e.KeyChar == 13)
            {
                this.Appliquer_Action();
                return;
            }

            //Si aucune case n'est selectionnée
            if (this.CurrentCell.Selected == false) return;

            int x = this.CurrentCellAddress.X;
            int y = this.CurrentCellAddress.Y;

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
            int valeurCourante = Int16.Parse((caseCourante == null ? "0" : caseCourante.V.ToString()) + e.KeyChar);
            if (valeurCourante <= 0 || valeurCourante > Sudoku.Taille) return;
            if (Sudoku.CaseEstUnIndice(x, y) || Sudoku.Grille[x, y] != 0) return;
            caseCourante = new CaseCourante(x, y, valeurCourante);
            AfficherGrille();
        }

        protected override void OnCurrentCellChanged(EventArgs e)
        {
            this.Appliquer_Action();
            Afficher();

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return;
            base.OnKeyDown(e);
        }

    }

    internal class CaseCourante
    {
        public int X;
        public int Y;
        public int V;

        public CaseCourante(int X, int Y, int V)
        {
            this.X = X;
            this.Y = Y;
            this.V = V;
        }
    }
}
