using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12.Classes
{
    internal class Circle: Figure
    {
        private double Radius;
        public Circle(double r)
        {
            Radius = r;
        }
        public override double Perimetr()
        {
            return 2 * Math.PI* Radius;
        }
        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
