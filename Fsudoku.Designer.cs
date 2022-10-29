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
            this.button1 = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dvg_motus = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_motus.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_motus.EnableHeadersVisualStyles = false;
            this.dvg_motus.Location = new System.Drawing.Point(164, 49);
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
            this.dvg_motus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_motus_CellContentClick);
            this.dvg_motus.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_motus_CellEnter);
            this.dvg_motus.Paint += new System.Windows.Forms.PaintEventHandler(this.dvg_motus_Paint);
            this.dvg_motus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dvg_motus_KeyPress);
            // 
            // Fsodoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 639);
            this.Controls.Add(this.dvg_motus);
            this.Controls.Add(this.button1);
            this.Name = "Fsodoku";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WindowsSodoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_motus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dvg_motus;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

