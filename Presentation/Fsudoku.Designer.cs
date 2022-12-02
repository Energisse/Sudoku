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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_rejouer = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_vie = new System.Windows.Forms.Label();
            this.bt_indice = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_indice = new System.Windows.Forms.Label();
            this.bt_notes = new System.Windows.Forms.Button();
            this.bt_effacer = new System.Windows.Forms.Button();
            this.gb_header = new System.Windows.Forms.GroupBox();
            this.timerLb = new Sodoku.Composants.TimerLabel();
            this.gb_bts = new System.Windows.Forms.GroupBox();
            this.img_retour = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grille = new Sodoku.Composants.Grille();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gb_header.SuspendLayout();
            this.gb_bts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_retour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_rejouer
            // 
            this.bt_rejouer.FlatAppearance.BorderSize = 0;
            this.bt_rejouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rejouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_rejouer.Image = ((System.Drawing.Image)(resources.GetObject("bt_rejouer.Image")));
            this.bt_rejouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_rejouer.Location = new System.Drawing.Point(226, 0);
            this.bt_rejouer.Name = "bt_rejouer";
            this.bt_rejouer.Size = new System.Drawing.Size(113, 55);
            this.bt_rejouer.TabIndex = 1;
            this.bt_rejouer.Text = "Rejouer";
            this.bt_rejouer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_rejouer.UseVisualStyleBackColor = true;
            this.bt_rejouer.Click += new System.EventHandler(this.Bt_rejouer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_vie
            // 
            this.lb_vie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vie.Location = new System.Drawing.Point(320, 48);
            this.lb_vie.Margin = new System.Windows.Forms.Padding(0);
            this.lb_vie.Name = "lb_vie";
            this.lb_vie.Size = new System.Drawing.Size(78, 50);
            this.lb_vie.TabIndex = 3;
            this.lb_vie.Text = "3";
            this.lb_vie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_indice
            // 
            this.bt_indice.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_indice.FlatAppearance.BorderSize = 0;
            this.bt_indice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_indice.Image = ((System.Drawing.Image)(resources.GetObject("bt_indice.Image")));
            this.bt_indice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_indice.Location = new System.Drawing.Point(339, 0);
            this.bt_indice.Name = "bt_indice";
            this.bt_indice.Size = new System.Drawing.Size(113, 55);
            this.bt_indice.TabIndex = 4;
            this.bt_indice.Text = "Indice";
            this.bt_indice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_indice.UseVisualStyleBackColor = true;
            this.bt_indice.Click += new System.EventHandler(this.Bt_indice_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lb_indice
            // 
            this.lb_indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_indice.Location = new System.Drawing.Point(42, 48);
            this.lb_indice.Margin = new System.Windows.Forms.Padding(0);
            this.lb_indice.Name = "lb_indice";
            this.lb_indice.Size = new System.Drawing.Size(100, 50);
            this.lb_indice.TabIndex = 6;
            this.lb_indice.Text = "3";
            this.lb_indice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_notes
            // 
            this.bt_notes.FlatAppearance.BorderSize = 0;
            this.bt_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_notes.Image = ((System.Drawing.Image)(resources.GetObject("bt_notes.Image")));
            this.bt_notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_notes.Location = new System.Drawing.Point(113, 0);
            this.bt_notes.Margin = new System.Windows.Forms.Padding(0);
            this.bt_notes.Name = "bt_notes";
            this.bt_notes.Size = new System.Drawing.Size(113, 55);
            this.bt_notes.TabIndex = 7;
            this.bt_notes.Text = "Noter";
            this.bt_notes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_notes.UseVisualStyleBackColor = true;
            this.bt_notes.Click += new System.EventHandler(this.Bt_notes_Click);
            // 
            // bt_effacer
            // 
            this.bt_effacer.BackColor = System.Drawing.Color.White;
            this.bt_effacer.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_effacer.FlatAppearance.BorderSize = 0;
            this.bt_effacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_effacer.Image = ((System.Drawing.Image)(resources.GetObject("bt_effacer.Image")));
            this.bt_effacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_effacer.Location = new System.Drawing.Point(0, 0);
            this.bt_effacer.Margin = new System.Windows.Forms.Padding(0);
            this.bt_effacer.Name = "bt_effacer";
            this.bt_effacer.Size = new System.Drawing.Size(113, 55);
            this.bt_effacer.TabIndex = 18;
            this.bt_effacer.Text = "Effacer";
            this.bt_effacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_effacer.UseVisualStyleBackColor = false;
            this.bt_effacer.Click += new System.EventHandler(this.Bt_effacer_Click);
            // 
            // gb_header
            // 
            this.gb_header.Controls.Add(this.pictureBox2);
            this.gb_header.Controls.Add(this.lb_vie);
            this.gb_header.Controls.Add(this.pictureBox1);
            this.gb_header.Controls.Add(this.lb_indice);
            this.gb_header.Controls.Add(this.timerLb);
            this.gb_header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_header.Location = new System.Drawing.Point(31, 2);
            this.gb_header.Margin = new System.Windows.Forms.Padding(0);
            this.gb_header.Name = "gb_header";
            this.gb_header.Padding = new System.Windows.Forms.Padding(0);
            this.gb_header.Size = new System.Drawing.Size(452, 98);
            this.gb_header.TabIndex = 22;
            this.gb_header.TabStop = false;
            // 
            // timerLb
            // 
            this.timerLb.BackColor = System.Drawing.Color.White;
            this.timerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLb.Location = new System.Drawing.Point(0, 0);
            this.timerLb.Name = "timerLb";
            this.timerLb.Size = new System.Drawing.Size(452, 98);
            this.timerLb.TabIndex = 19;
            this.timerLb.Text = "00:00";
            this.timerLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gb_bts
            // 
            this.gb_bts.Controls.Add(this.bt_indice);
            this.gb_bts.Controls.Add(this.bt_rejouer);
            this.gb_bts.Controls.Add(this.bt_notes);
            this.gb_bts.Controls.Add(this.bt_effacer);
            this.gb_bts.Location = new System.Drawing.Point(30, 555);
            this.gb_bts.Name = "gb_bts";
            this.gb_bts.Size = new System.Drawing.Size(452, 55);
            this.gb_bts.TabIndex = 23;
            this.gb_bts.TabStop = false;
            // 
            // img_retour
            // 
            this.img_retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_retour.Image = ((System.Drawing.Image)(resources.GetObject("img_retour.Image")));
            this.img_retour.Location = new System.Drawing.Point(29, 2);
            this.img_retour.Name = "img_retour";
            this.img_retour.Size = new System.Drawing.Size(50, 45);
            this.img_retour.TabIndex = 24;
            this.img_retour.TabStop = false;
            this.img_retour.Click += new System.EventHandler(this.Quiter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 50;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 50;
            // 
            // grille
            // 
            this.grille.AllowUserToAddRows = false;
            this.grille.AllowUserToDeleteRows = false;
            this.grille.AllowUserToResizeColumns = false;
            this.grille.AllowUserToResizeRows = false;
            this.grille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grille.ColumnHeadersVisible = false;
            this.grille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grille.DefaultCellStyle = dataGridViewCellStyle1;
            this.grille.EnableHeadersVisualStyles = false;
            this.grille.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.grille.Location = new System.Drawing.Point(28, 100);
            this.grille.Margin = new System.Windows.Forms.Padding(0);
            this.grille.MultiSelect = false;
            this.grille.Name = "grille";
            this.grille.Note = false;
            this.grille.ReadOnly = true;
            this.grille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grille.RowHeadersVisible = false;
            this.grille.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grille.ShowCellErrors = false;
            this.grille.ShowCellToolTips = false;
            this.grille.ShowEditingIcon = false;
            this.grille.ShowRowErrors = false;
            this.grille.Size = new System.Drawing.Size(452, 452);
            this.grille.Sudoku = null;
            this.grille.TabIndex = 0;
            this.grille.TabStop = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 50;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 50;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 50;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 50;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 50;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 50;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 50;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 50;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 50;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 50;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 50;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 50;
            // 
            // Fsodoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1402, 661);
            this.Controls.Add(this.img_retour);
            this.Controls.Add(this.gb_bts);
            this.Controls.Add(this.gb_header);
            this.Controls.Add(this.grille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fsodoku";
            this.Padding = new System.Windows.Forms.Padding(30, 100, 30, 50);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gb_header.ResumeLayout(false);
            this.gb_bts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_retour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_rejouer;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_vie;
        private System.Windows.Forms.Button bt_indice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_indice;
        private System.Windows.Forms.Button bt_notes;
        private System.Windows.Forms.Button bt_effacer;
        private Composants.TimerLabel timerLb;
        private System.Windows.Forms.GroupBox gb_header;
        private System.Windows.Forms.GroupBox gb_bts;
        private System.Windows.Forms.PictureBox img_retour;
        private Composants.Grille grille;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}

