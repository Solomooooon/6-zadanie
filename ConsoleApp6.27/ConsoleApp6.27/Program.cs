using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 E = new class1(-1, 3, 2);

            if (E.Est())
            {
                Console.WriteLine("Уравнение имеет действительные корни.");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней или коэффициент a не меньше 0.");
            }
        }
    }   
}
