using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dobbelstenen
{
    internal class Gooier
    {
        private Random random = new Random();
        public Gooier() { }

        public void gooi(Dobbelsteen steen)
        {
            int resultaat = random.Next(steen.aantalZijden);
            Console.WriteLine($"ik gooi een {resultaat + 1}");
        }
        
    }
}
