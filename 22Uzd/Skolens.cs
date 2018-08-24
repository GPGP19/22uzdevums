using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Uzd
{
    public class Skolens

    {
        public string Vards;
        public string Uzvards;
        public string Epasts;
        public int DzGads;
        public Klase Kl1;

        //public string Skolens1()
        {
            //return (Vards + ", " + Uzvards + ", " + Epasts + ", " + DzGads + " ," + Kl1.KlasesApraksts());
        }

            public void Izvade()

            { 
            Console.WriteLine("Skolēna vārds " + Vards + " uzvārds " + Uzvards + " Epasts" + Epasts + 
                                " dzimšanas gads " + DzGads);
            }


    }
}
