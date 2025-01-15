using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    public class Application10
    {
        public string Cerinta = "Cititi un numar n si inca un numar x si apoi n numere. Calculati numarul x in acest sir si afisati pozitia acestuia (sau un mesaj daca nu este citit).\r\n";
        public void Launch()
        {
            int n;
            int x;
            int p;

            Console.WriteLine("Adaugati numarul de numere:");
            string nInput = Console.ReadLine();
            Console.WriteLine("Adaugati x:");
            string xInput = Console.ReadLine();

            n = getInputNumber(nInput, 1);

            x = getInputNumber(xInput, 2);

            Console.WriteLine($"Acum adaugati {n} numere unul sub altul");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Numarul " + i);
                string pInput = Console.ReadLine();
                p = getInputNumber(pInput, 3);
                if (p == x)
                {
                    Console.WriteLine("Acesta este numarul");
                    return;
                };
            }

            int getInputNumber(string number, int order)
            {
                int num;
                bool numIsValid = int.TryParse(number, out num);
                while (!numIsValid)
                {
                    number = Console.ReadLine();
                    numIsValid = int.TryParse(number, out num);
                }
                return num;
            }
        }
    }
}
