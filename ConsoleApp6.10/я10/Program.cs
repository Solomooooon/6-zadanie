using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я10
{
    internal class Program
    {
        static void Main()
        {
            // Запрашиваем у пользователя ввод значения для N
            Console.Write("Введите значение для N: ");
            int N = int.Parse(Console.ReadLine());

            // Проверяем условия
            bool isEven = N % 2 == 0; // Условие 1: N четное
            bool notDivisibleBy3 = N % 3 != 0; // Условие 2: N не делится на 3
            bool divisibleBy7 = N % 7 == 0; // Условие 3: N делится на 7

            // Условие 4: Если N не делится на 5, то оно не должно делиться на 4
            bool condition4 = true;
            if (N % 5 != 0)
            {
                if (N % 4 == 0)
                {
                    condition4 = false;
                }
            }

            // Условие 5: Если N делится на 8, то оно должно делиться на 11
            bool condition5 = true;
            if (N % 8 == 0)
            {
                if (N % 11 != 0)
                {
                    condition5 = false;
                }
            }

            // Проверяем, все ли условия выполнены
            if (isEven && notDivisibleBy3 && divisibleBy7 && condition4 && condition5)
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
