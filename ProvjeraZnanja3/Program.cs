using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonaccijev niz definiran je na sljedeći način: 
            //• prvi član niza je 0
            //• drugi član niza je 1
            //• svaki sljedeći član niza jednak je zbroju prethodna dva člana
            //Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član
            //Fibonaccijevog niza


            int br1, rez = 0, x = 1, y = 0;
            Console.WriteLine("Unesite jedan broj: ");
            br1 = int.Parse(Console.ReadLine());

            if (br1 > 1)
            {
                for (int i = 0; i < br1; i++)
                {
                    for (int j = 1; j < br1; j++)
                    {
                        rez = y + x;
                        y = x;
                        x = rez;
                    }
                }
            }
            Console.WriteLine("Uneseni član iznosi: " + rez);
            Console.ReadKey();
        }
    }
}
