using System;
using System.Drawing;
using System.Windows.Forms;


namespace Sodoku.Composants
{
    class TimerLabel : Label
    {
        private readonly Timer timer;
        private int temps;

        public TimerLabel()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(TimerEvent);
            timer.Interval = 1000; 
            this.Text = "00:00";
            this.Font = new Font("Microsoft Sans Serif", 26);
            this.BackColor = SystemColors.Control;
        }
        

        private void TimerEvent(object sender, EventArgs e)
        {
            temps++;
            this.Afficher();
        }

        public void Start()
        {
            this.timer.Start();
        }
        public void Reset()
        {
            this.temps = 0;
            this.Afficher();
        }


        public void Stop()
        {
            this.timer.Stop();
        }

        private void Afficher()
        {
            this.Text = (temps / 60).ToString().PadLeft(2, '0') + ":" + (temps % 60).ToString().PadLeft(2, '0');
        }
    }
}
