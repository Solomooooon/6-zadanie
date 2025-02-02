using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я8
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Введите значение для N: ");
            int N = int.Parse(Console.ReadLine());

            
            if (N % 3 != 0 && N % 7 == 0 && N % 10 == 0)
            {
                Console.WriteLine("Условие выполнено: число N не делится на 3, но делится на 7 и 10.");
            }
            else
            {
                Console.WriteLine("Условие не выполнено.");
            }
        }
    }
}
