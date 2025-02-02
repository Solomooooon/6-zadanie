using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я4
{
    internal class Program
    {
        static void Main()
        {
            // Запрашиваем у пользователя ввод значения для N
            Console.Write("Введите значение для N: ");
            int N = int.Parse(Console.ReadLine());

            // Проверяем условия
            bool condition1 = true; // Условие 1: Если N делится на 3, то не делится на 9
            bool condition2 = true; // Условие 2: Если N делится на 4, то не делится на 5 и 24

            // Проверка условия 1
            if (N % 3 == 0)
            {
                if (N % 9 == 0)
                {
                    condition1 = false; // Если N делится на 9, условие 1 не выполнено
                }
            }

            // Проверка условия 2
            if (N % 4 == 0)
            {
                if (N % 5 == 0 || N % 24 == 0)
                {
                    condition2 = false; // Если N делится на 5 или 24, условие 2 не выполнено
                }
            }

            // Проверяем, оба ли условия выполнены
            if (condition1 && condition2)
            {
                Console.WriteLine("Условие выполнено.");
            }
            else
            {
                Console.WriteLine("Условие не выполнено.");
            }
        }
    }
}
