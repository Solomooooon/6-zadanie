using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND16
{ 
    class Program
    {
        static void Main()
        {
            EvenNumberChecker checker = new EvenNumberChecker(3, 4, 6, 7);

            bool result = checker.ExactlyTwoEven();
            if (result)
            {
                Console.WriteLine("Ровно два числа являются четными.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Не выполнено условие, что ровно два числа являются четными.");
                Console.ReadLine();
            }
        }
    }
}