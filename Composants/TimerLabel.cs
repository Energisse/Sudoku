using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sodoku.Composants
{
    class TimerLabel : Label
    {
        public TimerLabel()
        {
            this.Text = "00:00";
            this.Font = new Font("Microsoft Sans Serif", 26);
            this.BackColor = SystemColors.Control;
        }

        public void Afficher(int temps)
        {
            this.Text = (temps / 60).ToString().PadLeft(2, '0') + ":" + (temps % 60).ToString().PadLeft(2, '0');
        }
    }
}
