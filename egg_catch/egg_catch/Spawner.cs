using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace egg_catch
{
    internal class Spawner
    {
        public event EventHandler nieuwEi;
        private Ei ei;

        public Ei Ei { get { return ei; } }
        

        public Spawner()
        {
            Random random = new Random();
            int aantalEierenGespawned = 0;
        Timer timer = new Timer();
            timer.Interval = 50;
            timer.Enabled = true;
            timer.Tick += (sender, e) =>
            {
                if(random.Next(5) == 0)
                {
                    aantalEierenGespawned++;
                    int x = random.Next(800);
                    int speed = 100;
                    this.ei = new Ei($"ei{aantalEierenGespawned}", x,speed);
                    nieuwEi?.Invoke(this, EventArgs.Empty);
                }
            };
        }
    }
}
