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
            this.cb_niveau = new System.Windows.Forms.ComboBox();
            this.lb_difficulte = new System.Windows.Forms.Label();
            this.lb_taille = new System.Windows.Forms.Label();
            this.lv_sauvegarde = new System.Windows.Forms.ListView();
            this.ch_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Vie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Indice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Temps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_sauvegarde = new System.Windows.Forms.Label();
            this.gb_bt_nouvelle_partie = new System.Windows.Forms.GroupBox();
            this.bt_jouer = new System.Windows.Forms.Button();
            this.gb_bt_continuer = new System.Windows.Forms.GroupBox();
            this.bt_effacer = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_continuer = new System.Windows.Forms.Button();
            this.ch_difficute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_bt_nouvelle_partie.SuspendLayout();
            this.gb_bt_continuer.SuspendLayout();
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
            this.cb_taille.Location = new System.Drawing.Point(77, 44);
            this.cb_taille.Name = "cb_taille";
            this.cb_taille.Size = new System.Drawing.Size(121, 28);
            this.cb_taille.TabIndex = 22;
            this.cb_taille.Text = "9";
            // 
            // cb_niveau
            // 
            this.cb_niveau.FormattingEnabled = true;
            this.cb_niveau.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile",
            "Extreme"});
            this.cb_niveau.Location = new System.Drawing.Point(77, 96);
            this.cb_niveau.Name = "cb_niveau";
            this.cb_niveau.Size = new System.Drawing.Size(121, 28);
            this.cb_niveau.TabIndex = 24;
            this.cb_niveau.Text = "Facile";
            // 
            // lb_difficulte
            // 
            this.lb_difficulte.AutoSize = true;
            this.lb_difficulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_difficulte.Location = new System.Drawing.Point(74, 75);
            this.lb_difficulte.Name = "lb_difficulte";
            this.lb_difficulte.Size = new System.Drawing.Size(74, 18);
            this.lb_difficulte.TabIndex = 25;
            this.lb_difficulte.Text = "Difficulté";
            // 
            // lb_taille
            // 
            this.lb_taille.AutoSize = true;
            this.lb_taille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taille.Location = new System.Drawing.Point(74, 25);
            this.lb_taille.Name = "lb_taille";
            this.lb_taille.Size = new System.Drawing.Size(125, 16);
            this.lb_taille.TabIndex = 26;
            this.lb_taille.Text = "Taille de la grille";
            // 
            // lv_sauvegarde
            // 
            this.lv_sauvegarde.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Date,
            this.ch_Vie,
            this.ch_Indice,
            this.ch_Temps,
            this.ch_Taille,
            this.ch_difficute});
            this.lv_sauvegarde.FullRowSelect = true;
            this.lv_sauvegarde.HideSelection = false;
            this.lv_sauvegarde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_sauvegarde.Location = new System.Drawing.Point(9, 56);
            this.lv_sauvegarde.Margin = new System.Windows.Forms.Padding(0);
            this.lv_sauvegarde.MultiSelect = false;
            this.lv_sauvegarde.Name = "lv_sauvegarde";
            this.lv_sauvegarde.Size = new System.Drawing.Size(444, 147);
            this.lv_sauvegarde.TabIndex = 27;
            this.lv_sauvegarde.UseCompatibleStateImageBehavior = false;
            this.lv_sauvegarde.View = System.Windows.Forms.View.Details;
            this.lv_sauvegarde.SelectedIndexChanged += new System.EventHandler(this.lv_sauvegarde_SelectedIndexChanged);
            // 
            // ch_Date
            // 
            this.ch_Date.Text = "Date";
            this.ch_Date.Width = 120;
            // 
            // ch_Vie
            // 
            this.ch_Vie.Text = "Vie";
            // 
            // ch_Indice
            // 
            this.ch_Indice.Text = "Indice";
            // 
            // ch_Temps
            // 
            this.ch_Temps.Text = "Temps";
            // 
            // ch_Taille
            // 
            this.ch_Taille.Text = "Taille";
            // 
            // lb_sauvegarde
            // 
            this.lb_sauvegarde.AutoSize = true;
            this.lb_sauvegarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sauvegarde.Location = new System.Drawing.Point(31, 31);
            this.lb_sauvegarde.Name = "lb_sauvegarde";
            this.lb_sauvegarde.Size = new System.Drawing.Size(256, 25);
            this.lb_sauvegarde.TabIndex = 30;
            this.lb_sauvegarde.Text = "Partie(s) enregistrée(s)";
            // 
            // gb_bt_nouvelle_partie
            // 
            this.gb_bt_nouvelle_partie.Controls.Add(this.bt_jouer);
            this.gb_bt_nouvelle_partie.Controls.Add(this.lb_taille);
            this.gb_bt_nouvelle_partie.Controls.Add(this.cb_taille);
            this.gb_bt_nouvelle_partie.Controls.Add(this.lb_difficulte);
            this.gb_bt_nouvelle_partie.Controls.Add(this.cb_niveau);
            this.gb_bt_nouvelle_partie.Cursor = System.Windows.Forms.Cursors.Default;
            this.gb_bt_nouvelle_partie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_bt_nouvelle_partie.Location = new System.Drawing.Point(467, 31);
            this.gb_bt_nouvelle_partie.Name = "gb_bt_nouvelle_partie";
            this.gb_bt_nouvelle_partie.Size = new System.Drawing.Size(289, 172);
            this.gb_bt_nouvelle_partie.TabIndex = 31;
            this.gb_bt_nouvelle_partie.TabStop = false;
            this.gb_bt_nouvelle_partie.Text = "Nouvelle partie";
            // 
            // bt_jouer
            // 
            this.bt_jouer.FlatAppearance.BorderSize = 0;
            this.bt_jouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_jouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_jouer.Location = new System.Drawing.Point(96, 130);
            this.bt_jouer.Name = "bt_jouer";
            this.bt_jouer.Size = new System.Drawing.Size(87, 32);
            this.bt_jouer.TabIndex = 32;
            this.bt_jouer.Text = "Jouer";
            this.bt_jouer.UseVisualStyleBackColor = true;
            this.bt_jouer.Click += new System.EventHandler(this.bt_jouer_Click);
            // 
            // gb_bt_continuer
            // 
            this.gb_bt_continuer.Controls.Add(this.bt_effacer);
            this.gb_bt_continuer.Controls.Add(this.bt_annuler);
            this.gb_bt_continuer.Controls.Add(this.bt_continuer);
            this.gb_bt_continuer.Cursor = System.Windows.Forms.Cursors.Default;
            this.gb_bt_continuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_bt_continuer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_bt_continuer.Location = new System.Drawing.Point(467, 31);
            this.gb_bt_continuer.Name = "gb_bt_continuer";
            this.gb_bt_continuer.Size = new System.Drawing.Size(289, 172);
            this.gb_bt_continuer.TabIndex = 35;
            this.gb_bt_continuer.TabStop = false;
            this.gb_bt_continuer.Text = "Continuer";
            this.gb_bt_continuer.Visible = false;
            // 
            // bt_effacer
            // 
            this.bt_effacer.FlatAppearance.BorderSize = 0;
            this.bt_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_effacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_effacer.Location = new System.Drawing.Point(101, 132);
            this.bt_effacer.Name = "bt_effacer";
            this.bt_effacer.Size = new System.Drawing.Size(90, 32);
            this.bt_effacer.TabIndex = 34;
            this.bt_effacer.Text = "Effacer";
            this.bt_effacer.UseVisualStyleBackColor = true;
            this.bt_effacer.Click += new System.EventHandler(this.bt_effacer_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.FlatAppearance.BorderSize = 0;
            this.bt_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_annuler.Location = new System.Drawing.Point(6, 132);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(90, 32);
            this.bt_annuler.TabIndex = 33;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_continuer
            // 
            this.bt_continuer.FlatAppearance.BorderSize = 0;
            this.bt_continuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_continuer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_continuer.Location = new System.Drawing.Point(197, 132);
            this.bt_continuer.Name = "bt_continuer";
            this.bt_continuer.Size = new System.Drawing.Size(90, 32);
            this.bt_continuer.TabIndex = 32;
            this.bt_continuer.Text = "Continuer";
            this.bt_continuer.UseVisualStyleBackColor = true;
            this.bt_continuer.Click += new System.EventHandler(this.bt_continuer_Click);
            // 
            // ch_difficute
            // 
            this.ch_difficute.Text = "Difficulté";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 212);
            this.Controls.Add(this.lb_sauvegarde);
            this.Controls.Add(this.lv_sauvegarde);
            this.Controls.Add(this.gb_bt_continuer);
            this.Controls.Add(this.gb_bt_nouvelle_partie);
            this.Name = "FMenu";
            this.VisibleChanged += new System.EventHandler(this.FMenu_Shown);
            this.gb_bt_nouvelle_partie.ResumeLayout(false);
            this.gb_bt_nouvelle_partie.PerformLayout();
            this.gb_bt_continuer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_taille;
        private System.Windows.Forms.ComboBox cb_niveau;
        private System.Windows.Forms.Label lb_difficulte;
        private System.Windows.Forms.Label lb_taille;
        private System.Windows.Forms.ListView lv_sauvegarde;
        private System.Windows.Forms.ColumnHeader ch_Date;
        private System.Windows.Forms.ColumnHeader ch_Vie;
        private System.Windows.Forms.ColumnHeader ch_Indice;
        private System.Windows.Forms.ColumnHeader ch_Temps;
        private System.Windows.Forms.Label lb_sauvegarde;
        private System.Windows.Forms.ColumnHeader ch_Taille;
        private System.Windows.Forms.GroupBox gb_bt_nouvelle_partie;
        private System.Windows.Forms.Button bt_jouer;
        private System.Windows.Forms.GroupBox gb_bt_continuer;
        private System.Windows.Forms.Button bt_effacer;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_continuer;
        private System.Windows.Forms.ColumnHeader ch_difficute;
    }
}
