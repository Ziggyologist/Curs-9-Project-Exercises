using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ITSchool.AppUtilities;

namespace App4
{
    public class Application4 : ApplicationBase
    {
        public Application4()
        {
            Cerinta = "Cerinta ceva";
        }
        public override void Launch()
        {
            int a, b;


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

            Console.WriteLine("Dati o valoare pentru B: ");
            string bInput = Console.ReadLine();

            bool inputBValid = int.TryParse(bInput, out b);

            while (!inputBValid)
            {
                Console.WriteLine("Datele nu sunt valide. Introduceti din nou.");
                bInput = Console.ReadLine();
                inputBValid = int.TryParse(bInput, out b);
            }
            Console.WriteLine("Valoarea lui B este: " + b);

            if (a > b)
            {
                Console.WriteLine(a + " este mai mare decat " + b);
            }

        }
    }
}
