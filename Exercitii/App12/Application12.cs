using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    internal class Application12
    {
        public string Cerinta = "A12: Dati un numar natural de la tastatura. Numarul trebuie sa fie in intervalul definit in A11. Cautati numarul introdus in colectia generata in A11. Daca il gasiti, afisati poziţia lui si intrerupeti funcţionarea metodei, altfel afisati un mesaj corespunzator lipsei lui.Hint: cheia “break” intrerupa rularea unei structuri repetitive.";
        public void Launch()
        {
            Console.Write("Introduceti numarul de elemente pentru sir: ");
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


            Console.WriteLine("Arrayul are umratorea dimensiune: " + arrayElemente.Length);
            Console.Write("Introduceti un numar natural: ");
            int numarNatural;
            string numarNaturalInput = Console.ReadLine();
            bool numarNaturalValid = int.TryParse(numarNaturalInput, out numarNatural);

            /*
            foreach (int element in arrayElemente)
            {
                if( element == numarNatural)
                Console.WriteLine(element); 
            }
            */

            bool found = false;

            if (found == false)
            {
                for (int i = 0; i < arrayElemente.Length; i++)
                {
                    if (arrayElemente[i] == numarNatural)
                    {
                        Console.WriteLine("Numarul a fost gasit la pozitia: " + i);
                        found = true;
                        break;
                    }

                }
            }
            if (found == false)
            {
                Console.WriteLine("No numbers were found");
            }

        }
    }
}
