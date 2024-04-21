using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cone
    {
        double r1;
        double h1;
        public Cone(double r, double h)
        {
            this.r1 = r;
            this.h1 = h;
        }

        public double Base_Area()
        {
            return Math.PI * r1 * r1;
        }

        public double Total_Area()
        {
            double baseArea = Base_Area();
            double slantHeight = Math.Sqrt(r1 * r1 + h1 * h1);
            return baseArea + Math.PI * r1 * slantHeight;
        }
    }
}
