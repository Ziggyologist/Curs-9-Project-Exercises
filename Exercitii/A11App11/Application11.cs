using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    public class Application11
    {
        public string Cerinta = "A11: Realizati un generator de numere naturale aleatoare. Veti indica numarul de elemente si intervalul in care acestea pot avea valori. Valorile vor fi stocate intr-un array iar la final vor fi afisate in consola.";
        public void Launch()
        {
            int[] getArray(int limitaInferioara, int limitaSuperioara)
            {
                Console.Write("Introduceti numarul de elemente pentru sir: ");
                int numarElemente;
                string numarElementeInput = Console.ReadLine();
                bool elementeValid = int.TryParse(numarElementeInput, out numarElemente);

                int[] arrayElemente = new int[numarElemente];

                Random generatorDeNumareAleatoare = new Random();

                //generam valori aleatoare pentru fiecare pozitie din array
                for (int i = 0; i < arrayElemente.Length; i++)
                {
                    //atribuim un numar aleator pentru pozitia curenta din array
                    arrayElemente[i] = generatorDeNumareAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                    Console.WriteLine(arrayElemente[i]);
                }
                return arrayElemente;

            }

        }

    }
}
