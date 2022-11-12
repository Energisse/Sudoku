namespace Sodoku
{
    partial class Fsodoku
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsodoku));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_rejouer = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dvg_motus = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_vie = new System.Windows.Forms.Label();
            this.bt_indice = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_indice = new System.Windows.Forms.Label();
            this.bt_notes = new System.Windows.Forms.Button();
            this.bt_nb_1 = new System.Windows.Forms.Button();
            this.bt_nb_2 = new System.Windows.Forms.Button();
            this.bt_nb_3 = new System.Windows.Forms.Button();
            this.bt_nb_6 = new System.Windows.Forms.Button();
            this.bt_nb_5 = new System.Windows.Forms.Button();
            this.bt_nb_4 = new System.Windows.Forms.Button();
            this.bt_nb_9 = new System.Windows.Forms.Button();
            this.bt_nb_8 = new System.Windows.Forms.Button();
            this.bt_nb_7 = new System.Windows.Forms.Button();
            this.bt_effacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_rejouer
            // 
            this.bt_rejouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_rejouer.Image = ((System.Drawing.Image)(resources.GetObject("bt_rejouer.Image")));
            this.bt_rejouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_rejouer.Location = new System.Drawing.Point(456, 550);
            this.bt_rejouer.Name = "bt_rejouer";
            this.bt_rejouer.Size = new System.Drawing.Size(111, 55);
            this.bt_rejouer.TabIndex = 1;
            this.bt_rejouer.Text = "Rejouer";
            this.bt_rejouer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_rejouer.UseVisualStyleBackColor = true;
            this.bt_rejouer.Click += new System.EventHandler(this.Bt_rejouer_Click);
            // 
            // dvg_motus
            // 
            this.dvg_motus.AllowUserToAddRows = false;
            this.dvg_motus.AllowUserToDeleteRows = false;
            this.dvg_motus.AllowUserToResizeColumns = false;
            this.dvg_motus.AllowUserToResizeRows = false;
            this.dvg_motus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg_motus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvg_motus.ColumnHeadersVisible = false;
            this.dvg_motus.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_motus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_motus.EnableHeadersVisualStyles = false;
            this.dvg_motus.Location = new System.Drawing.Point(229, 77);
            this.dvg_motus.MultiSelect = false;
            this.dvg_motus.Name = "dvg_motus";
            this.dvg_motus.ReadOnly = true;
            this.dvg_motus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dvg_motus.RowHeadersVisible = false;
            this.dvg_motus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvg_motus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dvg_motus.ShowCellErrors = false;
            this.dvg_motus.ShowCellToolTips = false;
            this.dvg_motus.ShowEditingIcon = false;
            this.dvg_motus.ShowRowErrors = false;
            this.dvg_motus.Size = new System.Drawing.Size(452, 452);
            this.dvg_motus.TabIndex = 0;
            this.dvg_motus.Paint += new System.Windows.Forms.PaintEventHandler(this.Dvg_motus_Paint);
            this.dvg_motus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dvg_motus_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(633, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_vie
            // 
            this.lb_vie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vie.Location = new System.Drawing.Point(530, 19);
            this.lb_vie.Margin = new System.Windows.Forms.Padding(0);
            this.lb_vie.Name = "lb_vie";
            this.lb_vie.Size = new System.Drawing.Size(100, 55);
            this.lb_vie.TabIndex = 3;
            this.lb_vie.Text = "3";
            this.lb_vie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_indice
            // 
            this.bt_indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_indice.Image = ((System.Drawing.Image)(resources.GetObject("bt_indice.Image")));
            this.bt_indice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_indice.Location = new System.Drawing.Point(583, 550);
            this.bt_indice.Name = "bt_indice";
            this.bt_indice.Size = new System.Drawing.Size(96, 55);
            this.bt_indice.TabIndex = 4;
            this.bt_indice.Text = "Indice";
            this.bt_indice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_indice.UseVisualStyleBackColor = true;
            this.bt_indice.Click += new System.EventHandler(this.Bt_indice_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lb_indice
            // 
            this.lb_indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_indice.Location = new System.Drawing.Point(270, 19);
            this.lb_indice.Margin = new System.Windows.Forms.Padding(0);
            this.lb_indice.Name = "lb_indice";
            this.lb_indice.Size = new System.Drawing.Size(100, 55);
            this.lb_indice.TabIndex = 6;
            this.lb_indice.Text = "3";
            this.lb_indice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_notes
            // 
            this.bt_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_notes.Image = ((System.Drawing.Image)(resources.GetObject("bt_notes.Image")));
            this.bt_notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_notes.Location = new System.Drawing.Point(352, 550);
            this.bt_notes.Margin = new System.Windows.Forms.Padding(0);
            this.bt_notes.Name = "bt_notes";
            this.bt_notes.Size = new System.Drawing.Size(91, 55);
            this.bt_notes.TabIndex = 7;
            this.bt_notes.Text = "Noter";
            this.bt_notes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_notes.UseVisualStyleBackColor = true;
            this.bt_notes.Click += new System.EventHandler(this.Bt_notes_Click);
            // 
            // bt_nb_1
            // 
            this.bt_nb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_1.Location = new System.Drawing.Point(229, 625);
            this.bt_nb_1.Name = "bt_nb_1";
            this.bt_nb_1.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_1.TabIndex = 9;
            this.bt_nb_1.Text = "1";
            this.bt_nb_1.UseVisualStyleBackColor = true;
            this.bt_nb_1.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_2
            // 
            this.bt_nb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_2.Location = new System.Drawing.Point(279, 625);
            this.bt_nb_2.Name = "bt_nb_2";
            this.bt_nb_2.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_2.TabIndex = 10;
            this.bt_nb_2.Text = "2";
            this.bt_nb_2.UseVisualStyleBackColor = true;
            this.bt_nb_2.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_3
            // 
            this.bt_nb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_3.Location = new System.Drawing.Point(330, 625);
            this.bt_nb_3.Name = "bt_nb_3";
            this.bt_nb_3.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_3.TabIndex = 11;
            this.bt_nb_3.Text = "3";
            this.bt_nb_3.UseVisualStyleBackColor = true;
            this.bt_nb_3.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_6
            // 
            this.bt_nb_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_6.Location = new System.Drawing.Point(483, 625);
            this.bt_nb_6.Name = "bt_nb_6";
            this.bt_nb_6.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_6.TabIndex = 14;
            this.bt_nb_6.Text = "6";
            this.bt_nb_6.UseVisualStyleBackColor = true;
            this.bt_nb_6.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_5
            // 
            this.bt_nb_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_5.Location = new System.Drawing.Point(432, 625);
            this.bt_nb_5.Name = "bt_nb_5";
            this.bt_nb_5.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_5.TabIndex = 13;
            this.bt_nb_5.Text = "5";
            this.bt_nb_5.UseVisualStyleBackColor = true;
            this.bt_nb_5.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_4
            // 
            this.bt_nb_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_4.Location = new System.Drawing.Point(381, 625);
            this.bt_nb_4.Name = "bt_nb_4";
            this.bt_nb_4.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_4.TabIndex = 12;
            this.bt_nb_4.Text = "4";
            this.bt_nb_4.UseVisualStyleBackColor = true;
            this.bt_nb_4.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_9
            // 
            this.bt_nb_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_9.Location = new System.Drawing.Point(635, 625);
            this.bt_nb_9.Name = "bt_nb_9";
            this.bt_nb_9.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_9.TabIndex = 17;
            this.bt_nb_9.Text = "9";
            this.bt_nb_9.UseVisualStyleBackColor = true;
            this.bt_nb_9.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_8
            // 
            this.bt_nb_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_8.Location = new System.Drawing.Point(585, 625);
            this.bt_nb_8.Name = "bt_nb_8";
            this.bt_nb_8.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_8.TabIndex = 16;
            this.bt_nb_8.Text = "8";
            this.bt_nb_8.UseVisualStyleBackColor = true;
            this.bt_nb_8.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_nb_7
            // 
            this.bt_nb_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nb_7.Location = new System.Drawing.Point(534, 625);
            this.bt_nb_7.Name = "bt_nb_7";
            this.bt_nb_7.Size = new System.Drawing.Size(44, 44);
            this.bt_nb_7.TabIndex = 15;
            this.bt_nb_7.Text = "7";
            this.bt_nb_7.UseVisualStyleBackColor = true;
            this.bt_nb_7.Click += new System.EventHandler(this.Bts_nb_click);
            // 
            // bt_effacer
            // 
            this.bt_effacer.BackColor = System.Drawing.Color.Transparent;
            this.bt_effacer.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_effacer.FlatAppearance.BorderSize = 0;
            this.bt_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_effacer.Image = ((System.Drawing.Image)(resources.GetObject("bt_effacer.Image")));
            this.bt_effacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_effacer.Location = new System.Drawing.Point(229, 550);
            this.bt_effacer.Margin = new System.Windows.Forms.Padding(0);
            this.bt_effacer.Name = "bt_effacer";
            this.bt_effacer.Size = new System.Drawing.Size(114, 55);
            this.bt_effacer.TabIndex = 18;
            this.bt_effacer.Text = "Effacer";
            this.bt_effacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_effacer.UseVisualStyleBackColor = false;
            this.bt_effacer.Click += new System.EventHandler(this.Bt_effacer_Click);
            // 
            // Fsodoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 704);
            this.Controls.Add(this.bt_effacer);
            this.Controls.Add(this.bt_nb_9);
            this.Controls.Add(this.bt_nb_8);
            this.Controls.Add(this.bt_nb_7);
            this.Controls.Add(this.bt_nb_6);
            this.Controls.Add(this.bt_nb_5);
            this.Controls.Add(this.bt_nb_4);
            this.Controls.Add(this.bt_nb_3);
            this.Controls.Add(this.bt_nb_2);
            this.Controls.Add(this.bt_nb_1);
            this.Controls.Add(this.bt_notes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_indice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvg_motus);
            this.Controls.Add(this.bt_rejouer);
            this.Controls.Add(this.lb_vie);
            this.Controls.Add(this.lb_indice);
            this.Name = "Fsodoku";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WindowsSodoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_rejouer;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dvg_motus;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_vie;
        private System.Windows.Forms.Button bt_indice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_indice;
        private System.Windows.Forms.Button bt_notes;
        private System.Windows.Forms.Button bt_nb_1;
        private System.Windows.Forms.Button bt_nb_2;
        private System.Windows.Forms.Button bt_nb_6;
        private System.Windows.Forms.Button bt_nb_5;
        private System.Windows.Forms.Button bt_nb_4;
        private System.Windows.Forms.Button bt_nb_9;
        private System.Windows.Forms.Button bt_nb_8;
        private System.Windows.Forms.Button bt_nb_7;
        private System.Windows.Forms.Button bt_nb_3;
        private System.Windows.Forms.Button bt_effacer;
    }
}

