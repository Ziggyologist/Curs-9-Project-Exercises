using App1;
using App2;
using App3;
using App4;
using App6;
using App6_;
using App9;
using App15;
using App16;
using ITSchool.AppUtilities;

namespace ApplicationController;
internal class Program
{
    private static void Main(string[] args)
    {
        //ApplicationBase[] applications = [new Application01(), new Application02(), new Application03(), new Application4(), new Application15(), new Application16()];
        ApplicationBase[] applications = new ApplicationBase[]{new Application16(), new Application01(), new Application02(), new Application03(), new Application4(), new Application15() };

        List<ApplicationBase> apps = new List<ApplicationBase>();
        //ApplicationBase.Applications.Add(new Application01());
        //ApplicationBase.Applications.Add(new Application02());
        ApplicationBase.Applications.AddRange(applications);
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lista aplicatiilor: ");

            for (int i = 0; i < ApplicationBase.Applications.Count; i++)
            {
                Console.WriteLine($"Aplicatia {i + 1}. {ApplicationBase.Applications[i].Cerinta}");
            }
            Console.WriteLine("0. EXIT");

            int input = Utils.GetIntFromkeyboard();
            if (input == 0) { return; }
            if (input < ApplicationBase.Applications.Count)
            {
                applications[input - 1].Launch();

            } else { Console.WriteLine("Aplciatia dorita nu exista"); };
            Console.WriteLine("Apasati enter pentru a reveni la meniul anterior");
            Console.ReadLine();
        }
    }
}

// Sa se defineasca urmatoarele forme geometrice: cerc, patrat, dreptunghi, triunghi. Elemenelte trebuie sa poate oferi metode de calcul pentru arie si perimetru.