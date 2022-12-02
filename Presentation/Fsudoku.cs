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
using Sodoku.Composants;

namespace Sodoku
{
    public partial class Fsodoku : Form
    {
        private Sudoku Sudoku;
        private readonly int Taille;
        private readonly Difficulte Niveau;
        private int Vie;
        private int Indice;
        private Button[] Buttons;
        //case courrante où le joueur joue
        //(contrainte car la grille peut être supperieur a 9x9 donc certains nombres s'ecrivent sur 2 chiffres,
        //on enregistre la valeur avant de la valider si le curseur est deplacé ou le jouer a appuyé sur "Entrée") [x,y,valeur]
        public Fsodoku(int taille = 9, Difficulte niveau = Difficulte.Facile, int vie = 3, int indice = 3)
        {
            InitializeComponent();
            this.Sudoku = new Sudoku(taille, niveau, vie, indice);
            this.Taille = taille;
            this.Niveau = niveau;
            this.Vie = vie;
            this.Indice = indice;
            Init();
        }

        public Fsodoku(Sudoku sudoku)
        {
            InitializeComponent();
            this.Sudoku = sudoku;
            this.Taille = sudoku.Taille;
            this.Vie = sudoku.VieRestante;
            this.Indice = sudoku.IndiceRestant;
            this.Niveau = sudoku.Difficulte;
            Init();
        }

        private void Timer(object sender, EventArgs e)
        {
            timerLb.Afficher(this.Sudoku.Temps);
        }

        private void Init()
        {
            grille.Sudoku = this.Sudoku;
            this.Sudoku.Tick(this.Timer);
            timerLb.Afficher(this.Sudoku.Temps);
            this.Width = (Taille > 9 ? Taille :9 )  * 50 + this.Padding.Right + this.Padding.Left;
            this.Height =  Taille * 50 + 275;
            grille.Width = Taille * 50 +1;
            grille.Height = Taille * 50 +1;
            grille.Location = new Point(this.Width/2- grille.Width/2, grille.Location.Y);
            gb_header.Location = new Point(this.Width / 2 - gb_header.Width / 2, gb_header.Location.Y);
            gb_bts.Location = new Point(this.Width / 2 - gb_bts.Width / 2, grille.Location.Y + grille.Height + 10);

            //Création des boutons pour chaque chiffre
            Buttons = new Button[Taille];
            for (int i = 0; i < this.Taille; i++)
            {
                Button boutton = new Button();
                boutton.Text = (1 + i).ToString();
                boutton.Font = new Font("Microsoft Sans Serif", (i + 1) >= 10 ? 15 : 22, FontStyle.Bold);
                boutton.Margin = new Padding(3);
                boutton.Width = 44;
                boutton.Height = 44;
                boutton.TextAlign = ContentAlignment.MiddleCenter;
                boutton.Click += new System.EventHandler(this.Bts_nb_click);
                boutton.Location = new Point(grille.Location.X + i * 50 + 3, grille.Location.Y + Taille * 50 + 75);
                Buttons[i]=boutton;
                this.Controls.Add(boutton);
            }
            grille.onPlay += Afficher;
            Afficher();
        }

        private void Afficher()
        {
            lb_vie.Text = Sudoku.VieRestante.ToString();
            lb_indice.Text = Sudoku.IndiceRestant.ToString();
            bt_notes.BackColor = grille.Note ? Color.FromArgb(255, 170, 203, 255) : Color.White;
            for (int i = 0; i < Sudoku.NombreRestant.Length; i++)
            {
                if(Sudoku.NombreRestant[i] > 0)
                {
                    Buttons[i].Enabled = true;
                    Buttons[i].BackColor = Color.White;

                }
                else
                {
                    Buttons[i].Enabled = false;
                    Buttons[i].BackColor = Color.LightGray;

                }
            }
        }
        private void Bt_rejouer_Click(object sender, EventArgs e)
        {
            this.Sudoku.Dispose();
            Sauvegarde.Supprimer(this.Sudoku.DateTimeCreation.ToString());
            this.Sudoku = new Sudoku(this.Taille, this.Niveau,this.Vie,this.Indice);
            this.Sudoku.Tick(this.Timer);
            grille.Sudoku = this.Sudoku;
            timerLb.Afficher(this.Sudoku.Temps);
            Afficher();
        }

        private void Bt_indice_Click(object sender, EventArgs e)
        {
            grille.Indice();
        }

        private void Bt_notes_Click(object sender, EventArgs e)
        {
            grille.Note = !grille.Note;
            bt_notes.BackColor = grille.Note ? Color.FromArgb(255, 170, 203, 255) : Color.White;
        }

        private void Bts_nb_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            grille.Placer(grille.CurrentCell.ColumnIndex, grille.CurrentCell.RowIndex, Int16.Parse(btn.Text.ToString()));
        }

        private void Bt_effacer_Click(object sender, EventArgs e)
        {
            grille.Effacer(grille.CurrentCell.ColumnIndex, grille.CurrentCell.RowIndex);
        }

        private void Quiter(object sender, EventArgs e)
        {
            Sauvegarde.Sauvegarder(this.Sudoku);
            this.Sudoku.Dispose();
            this.Close();
            this.Dispose();
        }
    }
}
