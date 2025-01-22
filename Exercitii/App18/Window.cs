using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    public class Window
    {
        public Window()
        {
            Button button = new Button();
            button.Clicked += CandUnButonEsteApasat;
            Button button2 = new Button();
            button2.Clicked += CandUnButonEsteApasat;
            Button button3 = new Button();
            button3.Clicked += CandUnButonEsteApasat;
            Button button4 = new Button();
            button4.Clicked += CandUnButonEsteApasat;
        }
        public void CandUnButonEsteApasat()
        {
            Console.WriteLine("Un buton a fost apasat");
        }
    }
}
