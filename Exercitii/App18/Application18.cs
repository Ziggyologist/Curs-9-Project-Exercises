using ITSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    public class Application18 : ApplicationBase
    {
        public Application18()
        {
            Cerinta = "Realizati o aplicatie de tip consola in care sa indepliniti urmatoarele cerinte, in ordine:" +
                "\n- Creati o clasa numita “Button” in care sa definiti un eveniment“Clicked”. " +
                "Evenimentul va fi declansat printr-o metoda publica numita “SimulateClick”. Elementele trebuie sa fie parte din obiecte." +
                "\n- Creati o clasa numita “Window”. Aceasta se va abona la evenimentul “Clicked” al oricarui buton adaugat in Constructor, iar listenerul va afisa un mesaj in consola." +
                "\n- Extindeti clasa Button, adaugand ca argument la eveniment numele butonului. Modificati clasa Window astfel incat denumirea butonului apasat sa fie afisata." +
                "\n- Implementati un mecanism de citire de la tastatura in bucla. La introducerea corecta a denumirii unui buton existent, acestuia ii va fi apelata metoda “SimulateClick”." +
                "\n- Limitati elementele de cod astfel incat doar acele proprietati / metode dorite sa fie expuse..";
        }


        override public void Launch()
        {
            var window = new Window();
            window.Run();
        }
    }
    class Caine
    {
        public override string ToString()
        {
            return "Ham - ham";
        }
    }

    class Pisica
    {
        public override string ToString()
        {
            return "Miau - Miau";
        }
    }

    class Chiuahua : Caine
    {
        public override string ToString()
        {
            return "Chi  -hamham";
        }
    }

    class Akita : Caine
    {
        public override string ToString()
        {
            return "Aki - hamham";
        }
    }
    static class UtilityClass
    {
        public static void Output<T>(T item)
        {
            Console.WriteLine(item);
        }
        public static void Output2<T1, T2, T3>(T1 item, T2 item2, T3 item3)
        {
            Console.WriteLine("item2: " + item);
        }
        public static T ReturnItem<T>() where T : new() //aplicare constrangere
        {
            return new T();
        }
        public static T ReturnItemCaine<T>() where T : Caine, new() //aplicare constrangere
        {
            return new T();
        }
        public static void OutputString(string item)
        {
            Console.WriteLine(item);
        }

        public static void OutputString(float item)
        {
            Console.WriteLine(item);
        }
        public static void OutputString(bool item)
        {
            Console.WriteLine(item);
        }
        public static void OutputString(int item)
        {
            Console.WriteLine(item);
        }

        public static void OutputCaine(Caine item)
        {
            Console.WriteLine(item);
        }
    }



}
