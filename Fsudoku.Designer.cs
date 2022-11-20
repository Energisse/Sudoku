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
            this.dvg_motus = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_vie = new System.Windows.Forms.Label();
            this.bt_indice = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_indice = new System.Windows.Forms.Label();
            this.bt_notes = new System.Windows.Forms.Button();
            this.bt_effacer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerLb = new Sodoku.Composants.TimerLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_rejouer
            // 
            this.bt_rejouer.FlatAppearance.BorderSize = 0;
            this.bt_rejouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rejouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_rejouer.Image = ((System.Drawing.Image)(resources.GetObject("bt_rejouer.Image")));
            this.bt_rejouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_rejouer.Location = new System.Drawing.Point(837, 544);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_motus.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_motus.EnableHeadersVisualStyles = false;
            this.dvg_motus.Location = new System.Drawing.Point(608, 86);
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
            this.pictureBox1.Location = new System.Drawing.Point(1012, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_vie
            // 
            this.lb_vie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vie.Location = new System.Drawing.Point(909, 28);
            this.lb_vie.Margin = new System.Windows.Forms.Padding(0);
            this.lb_vie.Name = "lb_vie";
            this.lb_vie.Size = new System.Drawing.Size(100, 55);
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
            this.bt_indice.Location = new System.Drawing.Point(954, 544);
            this.bt_indice.Name = "bt_indice";
            this.bt_indice.Size = new System.Drawing.Size(106, 55);
            this.bt_indice.TabIndex = 4;
            this.bt_indice.Text = "Indice";
            this.bt_indice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_indice.UseVisualStyleBackColor = true;
            this.bt_indice.Click += new System.EventHandler(this.Bt_indice_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(608, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lb_indice
            // 
            this.lb_indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_indice.Location = new System.Drawing.Point(649, 28);
            this.lb_indice.Margin = new System.Windows.Forms.Padding(0);
            this.lb_indice.Name = "lb_indice";
            this.lb_indice.Size = new System.Drawing.Size(100, 55);
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
            this.bt_notes.Location = new System.Drawing.Point(733, 544);
            this.bt_notes.Margin = new System.Windows.Forms.Padding(0);
            this.bt_notes.Name = "bt_notes";
            this.bt_notes.Size = new System.Drawing.Size(91, 55);
            this.bt_notes.TabIndex = 7;
            this.bt_notes.Text = "Noter";
            this.bt_notes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_notes.UseVisualStyleBackColor = true;
            this.bt_notes.Click += new System.EventHandler(this.Bt_notes_Click);
            // 
            // bt_effacer
            // 
            this.bt_effacer.BackColor = System.Drawing.Color.Transparent;
            this.bt_effacer.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_effacer.FlatAppearance.BorderSize = 0;
            this.bt_effacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_effacer.Image = ((System.Drawing.Image)(resources.GetObject("bt_effacer.Image")));
            this.bt_effacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_effacer.Location = new System.Drawing.Point(610, 544);
            this.bt_effacer.Margin = new System.Windows.Forms.Padding(0);
            this.bt_effacer.Name = "bt_effacer";
            this.bt_effacer.Size = new System.Drawing.Size(114, 55);
            this.bt_effacer.TabIndex = 18;
            this.bt_effacer.Text = "Effacer";
            this.bt_effacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_effacer.UseVisualStyleBackColor = false;
            this.bt_effacer.Click += new System.EventHandler(this.Bt_effacer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(1098, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timerLb
            // 
            this.timerLb.BackColor = System.Drawing.SystemColors.Control;
            this.timerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.timerLb.Location = new System.Drawing.Point(608, 33);
            this.timerLb.Name = "timerLb";
            this.timerLb.Size = new System.Drawing.Size(452, 50);
            this.timerLb.TabIndex = 19;
            this.timerLb.Text = "00:00";
            this.timerLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Fsodoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2087, 704);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_effacer);
            this.Controls.Add(this.bt_notes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_indice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvg_motus);
            this.Controls.Add(this.bt_rejouer);
            this.Controls.Add(this.lb_vie);
            this.Controls.Add(this.lb_indice);
            this.Controls.Add(this.timerLb);
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
        private System.Windows.Forms.Button bt_effacer;
        private Composants.TimerLabel timerLb;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

