using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Uzd
{
    public class Klase

    {
        public String KlasesNosaukums;
        public int SkolenuSkaits;

        public Telpa T1;

        public string KlasesApraksts()
        {
            return (KlasesNosaukums + " , " + SkolenuSkaits + " , " + T1.TelpaW());
        }

    }
}
