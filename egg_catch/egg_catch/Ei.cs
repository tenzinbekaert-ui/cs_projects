using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egg_catch
{
    internal class Ei
    {
        public event EventHandler eifinished;
        public event EventHandler eiMoved;
        public Ei(string naam, int x, int speed)
        {
            int y = 0;

            Teller teller = new Teller(speed);
            teller.changed += (sender, e) =>
            {
                y = 800-teller.Getal;
                eiMoved?.Invoke(this, EventArgs.Empty);
                
            };
            teller.finished += (sender, e) =>
            {
                eifinished?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
