using ITSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSchool.AppUtilities;

namespace App2
{
    public class Application02 : ApplicationBase
    {
        public Application02()
        {
            Cerinta = "Cititi doua numere de la tastatura. Calculati produsul lor si afisati rezultatul.";
        }
        override public void Launch() 
        {
            int a = Utils.GetIntFromkeyboard("a");
            int b = Utils.GetIntFromkeyboard("b");
            int produs;
            produs = a * b;
            Console.WriteLine("produsul numerelor a si b este: " + produs);
        }
    }
}
