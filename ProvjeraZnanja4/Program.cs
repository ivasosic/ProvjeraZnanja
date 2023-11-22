using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napišite program koji će zatražiti od korisnika
            //da unese stranice trokuta odvojene razmakom,
            //te će provjeriti je li trokut pravokutan(npr. 6 8 10->DA)
            Console.WriteLine("-- 4. zadatak --");
            Console.WriteLine("Unesite tri stranice odvojene s razmakom");
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split(' ');
            int x = Convert.ToInt32(s2[0]);
            int y = Convert.ToInt32(s2[1]);
            int z = Convert.ToInt32(s2[2]);

            if (x * x + y * y == z * z)
            {
                Console.WriteLine("Unesene stranice: " +x+ " "+y+ " "+z+  " čine pravokutni trokut.");
            }
            else
            {
                Console.WriteLine("Unesene stranice: " + x + " " + y + " " + z + " ne čine pravokutni trokut.");
            }

;

            Console.ReadKey();

        }
    }
}
