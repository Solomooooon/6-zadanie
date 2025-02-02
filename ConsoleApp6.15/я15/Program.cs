using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите оценку по матиматике");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите оценку по физике");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите оценку по информатике");
            int C = int.Parse(Console.ReadLine());

            if (A == 4 || A == 5 && B == 4 || B == 5 && C == 4 || C == 5)
            {
                Console.WriteLine("Студент получит степендию");
            }
            else
            {
                Console.WriteLine("Студент НЕ получит степендию");
            }
        }
    }
}
