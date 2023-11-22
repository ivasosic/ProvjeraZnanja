using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanja_IvaSosic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napišite program u kojem ćete zatražiti od korisnika da unese jednu rečenicu.
            //Svaki razmak treba zamijeniti znakom '_'.
            Console.WriteLine("-- 1. zadatak --");
            Console.WriteLine("Unesite rečenicu: ");
            string rec = Console.ReadLine();
            string s1 = rec.Replace(" ", "_");
            Console.WriteLine("Nova rečenica: " + s1);

                Console.ReadKey();

        }
    }
}
