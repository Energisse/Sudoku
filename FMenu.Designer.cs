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
            "16",
            "18",
            "19",
            "20",
            "21",
            "22",
            "24",
            "25"});
            this.cb_taille.Location = new System.Drawing.Point(103, 111);
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
            this.bt_jouer.Location = new System.Drawing.Point(245, 92);
            this.bt_jouer.Name = "bt_jouer";
            this.bt_jouer.Size = new System.Drawing.Size(113, 55);
            this.bt_jouer.TabIndex = 23;
            this.bt_jouer.Text = "Jouer";
            this.bt_jouer.UseVisualStyleBackColor = true;
            this.bt_jouer.Click += new System.EventHandler(this.bt_jouer_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 212);
            this.Controls.Add(this.bt_jouer);
            this.Controls.Add(this.cb_taille);
            this.Name = "FMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_taille;
        private System.Windows.Forms.Button bt_jouer;
    }
}
