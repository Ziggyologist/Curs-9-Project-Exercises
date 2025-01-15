using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    public class Application9
    {
        public string Cerinta = "toate numerele de la 1 la 100 cu for";
        public void Launch()
        {
            int numar;
            string numarInput = Console.ReadLine();
            bool numIsValid = int.TryParse(numarInput, out numar);
            while (!numIsValid)
            {
                Console.WriteLine($"Numarul introdus nu este valid. Introduceti alt numar.");
                numarInput = Console.ReadLine();
                numIsValid = int.TryParse(numarInput, out numar);
            }
            Console.WriteLine(numar + " - corect");

            for (int i = 1; i < numar; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("numarul e par: " + i);
                }
            }

        }
    }
}
