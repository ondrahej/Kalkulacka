using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cislo = int.Parse(Console.ReadLine());
            //int cislo2 = int.Parse(Console.ReadLine());

            //int soucet = cislo + cislo2;
            //double odmocnina = Math.Round(Math.Sqrt(cislo), 3);


            //Console.WriteLine($"Výsledek: ");
            //Console.WriteLine(odmocnina);



            while (true)
            {
                Console.Write("Zadej číslo: ");
                int cislo1 = int.Parse(Console.ReadLine());
                Console.Write("Zadej druhé číslo: ");
                int cislo2 = int.Parse(Console.ReadLine());
                Console.Write("Zadej znaménko: ");
                string operace = Console.ReadLine();
                Console.Clear();
                double vysledek = 0;

                if (operace == "+")
                {
                    vysledek = cislo1 + cislo2;
                }
                else if (operace == "-")
                {
                    vysledek = cislo1 - cislo2;
                }
                else if (operace == "*")
                {
                    vysledek = cislo1 * cislo2;
                }
                else if (operace == "/")
                {
                    vysledek = cislo1 / cislo2;
                }
                else if (operace == "%")
                {
                    vysledek = cislo1 % cislo2;
                }

                else
                {
                    Console.WriteLine("Špatná operace");
                }

                Console.WriteLine($"Výsledek je: {vysledek}");
                Thread.Sleep(4000);
                Console.Clear();
            }

        }
    }
}
