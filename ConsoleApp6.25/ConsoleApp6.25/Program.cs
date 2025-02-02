using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
           class1 checker = new class1(14, 3, 10, 21);

          
            if (checker.CheckCondition())
            {
                Console.WriteLine("Условие выполнено: одно из чисел делится на 7, а другое является нечетным.");
            }
            else
            {
                Console.WriteLine("Условие не выполнено.");
            }
        }
    }
}
