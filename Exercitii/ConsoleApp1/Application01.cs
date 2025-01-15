using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSchool.AppUtilities;


namespace App1
{
    public class Application01 : ApplicationBase
    {
        public Application01()
        {
            Cerinta = "Aflati suma numerelor.";
        }
        override public void Launch()
        {
            int a = Utils.GetIntFromkeyboard();
            int b = Utils.GetIntFromkeyboard();
            int suma;
            suma = a + b;
            Console.WriteLine("Suma numerelor a si b este: " + suma);
        }
    }
}
