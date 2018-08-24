using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Uzd
{
    public class MacPr
    {
        public String Nosaukums;
        public Telpa Telpa1;
        public Skolotajs Skolotajs1;

        public string MacPrW()
        {
            return (Nosaukums + " " + Telpa1 + " " + Skolotajs1);

        }
    }

}


