using ITSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class Application03 : ApplicationBase
    {
        public Application03()
        {
            Cerinta = "Cititi un numar si calculatu patratul acestiua. Aflati rezultatul.";
        }
        override public void Launch()
        {
            int a = Utils.GetIntFromkeyboard("a");
            int patrat;
            int patrat2;
            patrat = a * a;
            patrat2 = (int)Math.Pow(a, 2);
            Console.WriteLine("Patratul lui a este: " + patrat);
            Console.WriteLine("Patratul lui a este: " + patrat2);
        }
    }
}
