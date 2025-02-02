using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я5
{
    internal class Program
    {
        static void Main()
        {
            // Запрашиваем у пользователя ввод значений для k, l, n, m
            Console.Write("Введите значение для k: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для l: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для m: ");
            int m = int.Parse(Console.ReadLine());

            // Проверяем условия
            bool condition1 = (n > 1) || (m < l + k && k == 0); // Условие 1: n > 1 или (m < l + k и k == 0)
            bool condition2 = true; // Условие 2: Если n > 2, то m² > 1

            // Проверка условия 2
            if (n > 2)
            {
                if (m * m <= 1)
                {
                    condition2 = false; // Если n > 2 и m² <= 1, условие 2 не выполнено
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
