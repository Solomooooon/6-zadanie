using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я7
{
    internal class Program
    {
        static void Main()
        {
           
            Console.Write("Введите значение для N: ");
            int N = int.Parse(Console.ReadLine());

            
            if (N % 2 == 0 && N % 7 == 0 && N % 11 != 0 && N % 13 != 0)
            {
                Console.WriteLine("Условие выполнено: число N четное, делится на 7, но не делится на 11 и 13.");
            }
            else
            {
                Console.WriteLine("Условие не выполнено.");
            }
        }
    }
}
