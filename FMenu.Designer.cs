namespace Sodoku
{
    partial class FMenu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_taille = new System.Windows.Forms.ComboBox();
            this.bt_jouer = new System.Windows.Forms.Button();
            this.cb_niveau = new System.Windows.Forms.ComboBox();
            this.lb_difficulte = new System.Windows.Forms.Label();
            this.lb_taille = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_taille
            // 
            this.cb_taille.FormattingEnabled = true;
            this.cb_taille.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "9",
            "10",
            "12",
            "14",
            "15",
            "16"});
            this.cb_taille.Location = new System.Drawing.Point(172, 69);
            this.cb_taille.Name = "cb_taille";
            this.cb_taille.Size = new System.Drawing.Size(121, 21);
            this.cb_taille.TabIndex = 22;
            this.cb_taille.Text = "9";
            // 
            // bt_jouer
            // 
            this.bt_jouer.FlatAppearance.BorderSize = 0;
            this.bt_jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_jouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_jouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_jouer.Location = new System.Drawing.Point(172, 142);
            this.bt_jouer.Name = "bt_jouer";
            this.bt_jouer.Size = new System.Drawing.Size(113, 55);
            this.bt_jouer.TabIndex = 23;
            this.bt_jouer.Text = "Jouer";
            this.bt_jouer.UseVisualStyleBackColor = true;
            this.bt_jouer.Click += new System.EventHandler(this.bt_jouer_Click);
            // 
            // cb_niveau
            // 
            this.cb_niveau.FormattingEnabled = true;
            this.cb_niveau.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile",
            "Extreme"});
            this.cb_niveau.Location = new System.Drawing.Point(172, 115);
            this.cb_niveau.Name = "cb_niveau";
            this.cb_niveau.Size = new System.Drawing.Size(121, 21);
            this.cb_niveau.TabIndex = 24;
            this.cb_niveau.Text = "Facile";
            // 
            // lb_difficulte
            // 
            this.lb_difficulte.AutoSize = true;
            this.lb_difficulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_difficulte.Location = new System.Drawing.Point(169, 94);
            this.lb_difficulte.Name = "lb_difficulte";
            this.lb_difficulte.Size = new System.Drawing.Size(74, 18);
            this.lb_difficulte.TabIndex = 25;
            this.lb_difficulte.Text = "Difficulté";
            // 
            // lb_taille
            // 
            this.lb_taille.AutoSize = true;
            this.lb_taille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taille.Location = new System.Drawing.Point(169, 50);
            this.lb_taille.Name = "lb_taille";
            this.lb_taille.Size = new System.Drawing.Size(125, 16);
            this.lb_taille.TabIndex = 26;
            this.lb_taille.Text = "Taille de la grille";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 212);
            this.Controls.Add(this.lb_taille);
            this.Controls.Add(this.lb_difficulte);
            this.Controls.Add(this.cb_niveau);
            this.Controls.Add(this.bt_jouer);
            this.Controls.Add(this.cb_taille);
            this.Name = "FMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_taille;
        private System.Windows.Forms.Button bt_jouer;
        private System.Windows.Forms.ComboBox cb_niveau;
        private System.Windows.Forms.Label lb_difficulte;
        private System.Windows.Forms.Label lb_taille;
    }
}
