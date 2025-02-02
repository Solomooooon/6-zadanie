using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._27
{
    class class1
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public class1(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double CD()
        {
            return B * B - 4 * A * C;
        }

        public bool Est()
        {
            double ds= CD();
            return A < 0 && ds >= 0;
        }
    }
}
