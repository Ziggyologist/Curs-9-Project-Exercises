using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17
{
    public class Rectangle : Shape
    {
        float Lungime;
        float Latime;
        public Rectangle(float lungime, float latime)
        {
            Lungime = lungime;
            Latime = latime;
        }
        public override float GetArea()
        {
            return (Lungime + Latime) * 2;
        }

        public override float GetPerimeter()
        {
            return Lungime * Latime;
        }
    }
}
