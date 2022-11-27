using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodoku.Composants
{
    internal class Tableau : DataGridView
    {
        public Tableau()
        {
            this.Font = new Font("Microsoft Sans Serif", 26);

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return;
            base.OnKeyDown(e);
        }
    }

}
