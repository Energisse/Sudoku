using System;
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
                this.Appliquer_Action();
                _Note = value;
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

        //Affiche les couleurs des case voisine et les cases avec la même valeur
        private void Afficher()
        {
            //Reinitialisation des du fond des Case
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
                this.Rows[y + yAbsolue].Cells[x + xAbsolue].Style.BackColor = CouleurVoisin;
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
        //Efface une case ou une note
        public void Effacer(int x, int y)
        {
            if (Note)
            {
                Sudoku.EffacerNote(x, y);
            }
            else
            {
                Sudoku.Effacer(x, y);
                this.CurrentCell.Style.SelectionBackColor = CouleurSelection;
                this.CurrentCell.Style.SelectionForeColor = Color.Black;
            }
            AfficherGrille();
        }

        //Affiches la grille
        private void AfficherGrille()
        {
            //Affichages des chiffres
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    this.Rows[y].Cells[x].Value = Sudoku.Grille[x, y].Valeur != 0 ? Sudoku.Grille[x, y].Valeur.ToString() : "";
                }
            }
            //Affichage de l'action courant
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
            this.ClearSelection();
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                this.Columns[x].Width = 50;
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    this.Rows[y].Cells[x] = new DataGridViewCase(Sudoku.Grille[x,y]);
                    this.Rows[y].Height = 50;
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
            AfficherGrille();
        }
        //Affiche la grille complete
        private void AfficherGrilleMort()
        {
            for (int x = 0; x < Sudoku.Taille; x++)
            {
                for (int y = 0; y < Sudoku.Taille; y++)
                {
                    this.Rows[y].Cells[x].Value = Sudoku.Grille[x, y].Solution.ToString();
                    if (!Sudoku.Grille[x, y].EstValide())
                    {
                        ((DataGridViewCase)this.Rows[y].Cells[x]).Reponse = true;
                    }
                }
            }
        }

        public void Indice()
        {
            if (Sudoku.EstMort()) return;
            (int x, int y,int v) = Sudoku.Indice();
            if (x == -1) return;
            this.AfficherGrille();
            Placer(x, y, v,false);        
            this.Rows[y].Cells[x].Selected = true;
        }

        public void Placer(int x, int y, int v)
        {
            this.Placer(x, y,v,this.Note);
        }
        private void Placer(int x, int y, int v,bool noter)
        {
            if (noter)
            {
                Sudoku.Noter( x, y,v);
            }
            else
            {
               Sudoku.Jouer(x, y, v);
               onPlay();
               if (Sudoku.EstMort())
               {
                   MessageBox.Show("C'est perdu", "Perdu");
                   AfficherGrilleMort();
                   return;
               }
               else if (Sudoku.AGagne())
               {
                   MessageBox.Show("C'est gagné", "Gagné");
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
         
            //Affiche l'action "Note" courante 
            if (caseCourante != null && _Note == true)
            {
                if(Sudoku.Grille[caseCourante.X, caseCourante.Y].EstJouable())
                {
                    bool effacement = Sudoku.Grille[caseCourante.X, caseCourante.Y].Notes[caseCourante.V - 1];
                    //Effacement en ecrivant de la couleur du fond
                    Brush brush = effacement ? new SolidBrush(CouleurSelection) : new SolidBrush(Color.Gray);
                    e.Graphics.DrawString(caseCourante.V.ToString(), new Font("Arial", police, FontStyle.Bold), brush, caseCourante.X * 50 + ((caseCourante.V - 1) % largeur) * 50 / largeur, caseCourante.Y * 50 + ((caseCourante.V - 1) / largeur) * 50 / largeur);
                }

            }
            //Affiche les lignes noires
            for (int x = 0; x < Sudoku.Taille; x += Sudoku.LargeurGroupe)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), x * 50, 0, x * 50, Sudoku.Taille * 50);
            }
            for (int y = 0; y < Sudoku.Taille; y += Sudoku.HauteurGroupe)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, y * 50, Sudoku.Taille * 50, y * 50);
            }
        }

        //Aplique l'action courante
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

            //Si "n"  appuyé alors togle noter
            if ((int)e.KeyChar == 110)
            {
                this.Note = !this.Note;
                this.onPlay();
                return;
            }

            //Si "Entrée" est appuyé on applique l'action
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
            
            if (!Sudoku.Grille[x, y].EstJouable()) return;

            //On prends uniquement les chiffre de 0 a 9
            //Ascii code des nombres [0;9] = [48;57]
            if ((int)e.KeyChar < 48 || (int)e.KeyChar > 57) return;
            //On limite le chiffre max a la taille du sudoku, si la taille est 6, le plus grand chiffre jouable est 6
            if ((int)e.KeyChar-48 > Sudoku.Taille) return;
            //Concatenation des chiffres saisie
            int valeurCourante = Int16.Parse((caseCourante == null ? "0" : caseCourante.V.ToString()) + e.KeyChar);
            if (valeurCourante <= 0) return;

            if (valeurCourante > Sudoku.Taille)
            {
                if ((int)e.KeyChar == 48) return;
                valeurCourante = (int)e.KeyChar-48;
            }
            caseCourante = new CaseCourante(x, y, valeurCourante);
            AfficherGrille();
        }

        //Lorsque la case courante est changé on applique l'action
        protected override void OnCurrentCellChanged(EventArgs e)
        {
            this.Appliquer_Action();
            Afficher();
        }

        //Empeche le deplacement du curseur lorsque "Entrée" est appuyé 
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
