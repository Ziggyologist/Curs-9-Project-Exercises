using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    public class Window
    {
        private List<Button> buttons = new List<Button>();

        public Window()
        {
            var button1 = new Button("Button1");
            var button2 = new Button("Button2");
            var button3 = new Button("Button3");
            var button4 = new Button("Button4");

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);

            foreach (var button in buttons)
            {
                button.Clicked += CandUnButonEsteApasat;
            }
        }
        public void CandUnButonEsteApasat()
        {
            Console.WriteLine("Un buton a fost apasat");
        }

        public void Run()
        {
            Console.WriteLine("Introduceti numele unui buton (ex. 'Button1', 'Button2') sau 'exit' pentru a iesi:");
            string input;
            while ((input = Console.ReadLine())?.ToLower() != "exit")
            {
                // Găsim butonul după nume
                var button = buttons.Find(b => b.Name.Equals(input, StringComparison.OrdinalIgnoreCase));
                if (button != null)
                {
                    button.SimulateClick();
                }
                else
                {
                    Console.WriteLine("Numele introdus nu este valid. Incercati din nou.");
                }
            }
            Console.WriteLine("Saluti.");
        }
    }
}
