using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace egg_catch
{
    internal class Teller
    {
        private int getal = 800;
        public event EventHandler changed;
        public event EventHandler finished;
        public int Getal { get { return getal; } }
        public Teller(int speed)
        {
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Enabled = true;
            timer.Tick += (sender, e) =>
            {
                getal = getal - speed/20;
                changed?.Invoke(this, EventArgs.Empty);
                if (getal <= 0)
                {
                    finished?.Invoke(this, EventArgs.Empty);
                    timer.Enabled = false;  
                }
            };
        }
    }
}
