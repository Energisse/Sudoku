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
            this.gb_header = new System.Windows.Forms.GroupBox();
            this.timerLb = new Sodoku.Composants.TimerLabel();
            this.gb_bts = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gb_header.SuspendLayout();
            this.gb_bts.SuspendLayout();
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
            this.dvg_motus.Location = new System.Drawing.Point(30, 66);
            this.dvg_motus.Margin = new System.Windows.Forms.Padding(0);
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
            this.dvg_motus.TabStop = false;
            this.dvg_motus.SelectionChanged += new System.EventHandler(this.dvg_motus_SelectionChanged);
            this.dvg_motus.Paint += new System.Windows.Forms.PaintEventHandler(this.Dvg_motus_Paint);
            this.dvg_motus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dvg_motus_KeyDown);
            this.dvg_motus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dvg_motus_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_vie
            // 
            this.lb_vie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vie.Location = new System.Drawing.Point(301, 0);
            this.lb_vie.Margin = new System.Windows.Forms.Padding(0);
            this.lb_vie.Name = "lb_vie";
            this.lb_vie.Size = new System.Drawing.Size(100, 50);
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
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lb_indice
            // 
            this.lb_indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_indice.Location = new System.Drawing.Point(41, 0);
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
            this.gb_header.Location = new System.Drawing.Point(31, 16);
            this.gb_header.Margin = new System.Windows.Forms.Padding(0);
            this.gb_header.Name = "gb_header";
            this.gb_header.Padding = new System.Windows.Forms.Padding(0);
            this.gb_header.Size = new System.Drawing.Size(452, 50);
            this.gb_header.TabIndex = 22;
            this.gb_header.TabStop = false;
            // 
            // timerLb
            // 
            this.timerLb.BackColor = System.Drawing.Color.White;
            this.timerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.timerLb.Location = new System.Drawing.Point(-1, 0);
            this.timerLb.Name = "timerLb";
            this.timerLb.Size = new System.Drawing.Size(452, 50);
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
            this.gb_bts.Location = new System.Drawing.Point(30, 521);
            this.gb_bts.Name = "gb_bts";
            this.gb_bts.Size = new System.Drawing.Size(452, 55);
            this.gb_bts.TabIndex = 23;
            this.gb_bts.TabStop = false;
            // 
            // Fsodoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1402, 661);
            this.Controls.Add(this.gb_bts);
            this.Controls.Add(this.gb_header);
            this.Controls.Add(this.dvg_motus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fsodoku";
            this.Padding = new System.Windows.Forms.Padding(30, 100, 30, 50);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Load += new System.EventHandler(this.WindowsSodoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gb_header.ResumeLayout(false);
            this.gb_bts.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gb_header;
        private System.Windows.Forms.GroupBox gb_bts;
    }
}

