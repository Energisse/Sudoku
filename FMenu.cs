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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void bt_jouer_Click(object sender, EventArgs e)
        {
            Difficulte difficulte = Difficulte.Facile;
            switch (cb_niveau.Text.ToString())
            {
                case "Extreme":
                    difficulte = Difficulte.Extreme;
                    break;
                case "Difficile":
                    difficulte = Difficulte.Difficile;
                    break;
                case "Moyen":
                    difficulte = Difficulte.Moyen;
                    break;
            }
            var frm = new Fsodoku(Int16.Parse(cb_taille.Text.ToString()), difficulte);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
