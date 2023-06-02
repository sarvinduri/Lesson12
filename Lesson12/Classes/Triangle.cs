using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12.Classes
{
    internal class Triangle : Figure
    {
        private double Side1, Side2, Side3;
        public bool Exist
        {
            get
            {
                return (Side1 + Side2 > Side3) && (Side1 + Side3 > Side2) && (Side2 + Side3 > Side1);
            }
        }
        public Triangle (double s1, double s2, double s3)
        {
            Side1= s1;
            Side2= s2;
            Side3= s3;
        }
        public override double Perimetr()
        {
            return Side1 + Side2 + Side3; 
        }
        public override double Square()
        {
            double p = Perimetr()/2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
