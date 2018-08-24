using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Uzd
{
    public class Vertejums

    {
        public int Atzime;
        public MacPr Nosaukums;
        public Skolens SkolX;

        public void VertejumaIzvade()
        {
            Console.WriteLine ("Info par skolēnu " + SkolX.Skolens1() + Nosaukums.MacPrW() + Atzime);
        }

    }
}
