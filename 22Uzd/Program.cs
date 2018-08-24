using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Uzd
{
    class Program

    {
        static void Main(string[] args)
        {
            SkolensRulle();
            Console.ReadLine();
        }

        static void SkolensRulle()
        {
            Skolens sk22 = new Skolens();
            sk22.Vards = "Roberts";
            sk22.Uzvards = " Locis";
            sk22.Epasts = " RL@kkk.com";
            sk22.DzGads =  1996;
            sk22.Izvade();
           
        
            Vertejums v1 = new Vertejums();
            v1.Atzime = 8;
            v1.VertejumaIzvade();
            

            Telpa t1 = new Telpa();
            t1.TelpasNumurs = 208;
            t1.TelpasStavs = 5;
            t1.TelpaW();
          

            Skolotajs teacher = new Skolotajs();
            teacher.Vards = "Jana";
            teacher.Uzvards = "Klusaa";
            teacher.Epasts = "Jana.Klusaa@inbox.lv";
            

        }  
    }
}


    