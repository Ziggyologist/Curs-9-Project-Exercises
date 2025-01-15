using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6_
{
    public class Application6
    {
        public string Cerinta = " Cititi un numar si afisati toate numerele de la 1 la n";
        public void Launch()
        {
            Console.WriteLine("App 6.");
            int numar;
            string numarInput = Console.ReadLine();
            numar = getInputNumber(numarInput, 1);

            for (int index = 1; index < numar; index++)
            {
                Console.WriteLine(index + ". numar.");
            }


            // Citi un numar n si afisati suma primerlor n numere naturale
            Console.WriteLine("App 7.");
            int n;
            int suma = 0;
            string nInput = Console.ReadLine();
            n = getInputNumber(nInput, 1);

            for (int index = 0; index < n; index++)
            {
                Console.Write(suma + "+" + index + "= ");

                suma += index;
                Console.Write(suma + ";");
                Console.WriteLine();
            }
            Console.WriteLine(suma);



            int getInputNumber(string number, int order)
            {
                int num;
                bool numIsValid = int.TryParse(number, out num);
                while (!numIsValid)
                {
                    Console.WriteLine($"Numarul {order} introdus nu este valid. Introduceti alt numar.");
                    number = Console.ReadLine();
                    numIsValid = int.TryParse(number, out num);
                }
                Console.WriteLine($"Valoarea pentru numarul {order} este {num}.");
                return num;
            }

        }
    }
}
