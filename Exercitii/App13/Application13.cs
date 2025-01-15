using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace App13
{
    public class Application13
    {
        public string Cerinta = "APP 11: Introduceti numarul de elemente pentru sir";
        public void Launch()
        {
            int numarElemente;
            string numarElementeInput = Console.ReadLine();
            bool elementeValid = int.TryParse(numarElementeInput, out numarElemente);
            const int limitaInferioara = -10;
            const int limitaSuperioara = 10;
            int[] arrayElemente = new int[numarElemente];

            Random generatorDeNumareAleatoare = new Random();

            //generam valori aleatoare pentru fiecare pozitie din array
            for (int i = 0; i < arrayElemente.Length; i++)
            {
                //atribuim un numar aleator pentru pozitia curenta din array
                arrayElemente[i] = generatorDeNumareAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                Console.WriteLine(arrayElemente[i]);
            }

            //App 13
            //Calculati suma numerelor pozitive dinrt-un sir de numere intregi (A11). Folositi cheia continue pentru a sari peste numerele negative.
            int suma = 0;
            for (int i = 0; i < arrayElemente.Length; i++)
            {
                if (arrayElemente[i] < 0)
                {
                    continue;
                }
                suma += arrayElemente[i];
            }
            Console.WriteLine("Suma tuturor numerelor pozitive este: " + suma);
        }
    }
}
