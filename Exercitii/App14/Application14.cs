using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class Application14
    {
        public string Cerinta = "//Afisati toate numerele care sunt prime dintr-un sir de numere intregi (generat la A11).\r\n//Un numar este prim daca acesta se imparte fara rest doar la 1 si la el insusi.\r\n//Ignorati orice numar din sir care este -1, 0 sau 1.";
        public void Launch()
        {

            int[] sir = getArray(-100, 100);
            bool prim = false;

            foreach (var item in sir)
            {
                if (item == -1 || item == 0 || item == 1) { }
                else
                {
                    prim = verificaNumarPrim(item);
                }
            }


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

            bool verificaNumarPrim(int numar)
            {
                for (int i = 2; i < numar; i++)
                {
                    if (numar % i == 0)
                    {
                        return false;
                    }
                }
                return true;

            }
        }
    }
}
