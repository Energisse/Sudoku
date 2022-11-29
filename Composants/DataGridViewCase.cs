using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodoku.Composants
{

    public class DataGridViewCase : DataGridViewTextBoxCell
    {
        public bool Reponse = false;
        public Case SudokuCase;
        public DataGridViewCase(Case SudokuCase)
        {
            this.SudokuCase = SudokuCase;
        }

        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
           value, formattedValue, errorText, cellStyle,
           advancedBorderStyle, paintParts);

            //Si c'est un indice rien n'est a faire
            if (this.SudokuCase.EstUnIndice()) return;
            
            //Si c'est une case reponse (en cas de perte)
            if (Reponse)
            {
                this.Style.ForeColor = Color.Red;
                this.Style.SelectionBackColor = Color.Red;
                this.Style.SelectionForeColor = Color.White;
            }
            else
            {
                if (!this.SudokuCase.EstVide())
                {
                    if (this.SudokuCase.EstValide())
                    {
                        this.Style.ForeColor = Color.Blue;
                        this.Style.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        this.Style.ForeColor = Color.Red;
                        this.Style.SelectionBackColor = Color.Red;
                        this.Style.SelectionForeColor = Color.White;
                    }
                }
            }
            if (!this.SudokuCase.EstVide()) return;
            //Affichage des notes
            for (int z = 0; z < this.SudokuCase.Notes.Length; z++)
            {
                if (this.SudokuCase.Notes[z])
                {
                    int largeur = (int)Math.Ceiling(Math.Sqrt(SudokuCase.Taille));
                    int police = 30 / largeur;
                    graphics.DrawString((z+1).ToString(), new Font("Arial", police, FontStyle.Bold), Brushes.Gray, cellBounds.X + (z % largeur) * cellBounds.Width / largeur, cellBounds.Y + (z / largeur) * cellBounds.Width / largeur);
                }
            }
        }
    }
}
