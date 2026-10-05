using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobbelstenen
{
    internal class Dobbelsteen
    {
        public int aantalZijden = 6;

        public Dobbelsteen() { }
        public Dobbelsteen(int aantalZijden)
        {
            this.aantalZijden = aantalZijden;
        }
    }
}
