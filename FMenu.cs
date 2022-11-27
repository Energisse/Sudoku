using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodoku
{
    public partial class FMenu : Form
    {
        string Selection = null;
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
            Fsodoku frm = new Fsodoku(Int16.Parse(cb_taille.Text.ToString()), difficulte);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            gb_bt_continuer.Visible = false;
            gb_bt_nouvelle_partie.Visible = true;
            this.Selection = null;
            lv_sauvegarde.SelectedItems.Clear();
        }

        private void lv_sauvegarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_sauvegarde.SelectedItems.Count == 0) return;
            gb_bt_continuer.Visible = true;
            gb_bt_nouvelle_partie.Visible = false;
            Selection = lv_sauvegarde.SelectedItems[0].SubItems[5].Text;
        }

        private void bt_effacer_Click(object sender, EventArgs e)
        {
            if (lv_sauvegarde.SelectedItems.Count == 0) return;
            Sauvegarde.Supprimer(lv_sauvegarde.SelectedItems[0].SubItems[5].Text);
            lv_sauvegarde.SelectedItems[0].Remove();
            gb_bt_continuer.Visible = false;
            gb_bt_nouvelle_partie.Visible = true;
        }

        private void bt_continuer_Click(object sender, EventArgs e)
        {
            Fsodoku frm = new Fsodoku(Sauvegarde.Charger(Selection));
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void FMenu_Shown(object sender, EventArgs e)
        {
            lv_sauvegarde.Items.Clear();
            foreach (JToken sauvegarde in Sauvegarde.Charger())
            {
                ListViewItem l = new ListViewItem(DateTime.FromFileTime(Int64.Parse((string)sauvegarde["DateTimeCreation"])).ToString());
                l.SubItems.Add((string)sauvegarde["VieRestante"]);
                l.SubItems.Add((string)sauvegarde["IndiceRestant"]);
                l.SubItems.Add((string)sauvegarde["Temps"]);
                l.SubItems.Add((string)sauvegarde["Taille"]);
                //Colonne invisible permetant de connaitre la partie par sa date de création
                l.SubItems.Add((string)sauvegarde["DateTimeCreation"]);
                lv_sauvegarde.Items.Add(l);
            }
        }
    }
}
