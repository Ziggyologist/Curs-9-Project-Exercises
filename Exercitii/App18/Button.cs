using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    public class Button { 
        public event Action Clicked;
        public string Name {  get; set; }
        public Button(string name)
        {
            Name = name;
        }
        public void SimulateClick()
        {
            Clicked?.Invoke();
        }

    }
}
