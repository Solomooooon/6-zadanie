using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            class1 checker = new class1(N);

         checker.CheckCondition();
        }
    }
}
