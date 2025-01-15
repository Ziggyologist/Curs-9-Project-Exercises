using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    public class Application6
    {
        public string Cerinta;
        public void Launch()
        {
            int a;


            Console.WriteLine("Introduceti o valoare pentru A: ");
            string aInput = Console.ReadLine();
            bool inputAValid = int.TryParse(aInput, out a);

            while (!inputAValid)
            {
                Console.WriteLine("Datele nu sunt valide. Introduceti din nou.");
                aInput = Console.ReadLine();
                inputAValid = int.TryParse(aInput, out a);
            }
            Console.WriteLine($"Valoarea lui A este: {a}");



            if (a % 2 == 0)
            {
                Console.WriteLine(a + " este par");
            }
            else
            {
                Console.Write(a + " este impar");
            };
        }
    }
}
