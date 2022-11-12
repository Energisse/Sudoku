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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsodoku));
            this.bt_rejouer = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dvg_motus = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_vie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_rejouer
            // 
            this.bt_rejouer.Location = new System.Drawing.Point(747, 45);
            this.bt_rejouer.Name = "bt_rejouer";
            this.bt_rejouer.Size = new System.Drawing.Size(75, 23);
            this.bt_rejouer.TabIndex = 1;
            this.bt_rejouer.Text = "Rejouer";
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
            this.lb_vie.AutoSize = true;
            this.lb_vie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vie.Location = new System.Drawing.Point(594, 19);
            this.lb_vie.Margin = new System.Windows.Forms.Padding(0);
            this.lb_vie.Name = "lb_vie";
            this.lb_vie.Size = new System.Drawing.Size(51, 55);
            this.lb_vie.TabIndex = 3;
            this.lb_vie.Text = "3";
            this.lb_vie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Fsodoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvg_motus);
            this.Controls.Add(this.bt_rejouer);
            this.Controls.Add(this.lb_vie);
            this.Name = "Fsodoku";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WindowsSodoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_rejouer;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dvg_motus;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_vie;
    }
}

