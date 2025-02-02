using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я13
{
    internal class Program
    {
        static void Main()
        {
            // Ввод данных
            Console.Write("Введите время начала разговора (0-24): ");
            int t = int.Parse(Console.ReadLine());

            Console.Write("Введите продолжительность разговора (в минутах): ");
            int dt = int.Parse(Console.ReadLine());

            Console.Write("Введите стоимость минуты разговора: ");
            double s = double.Parse(Console.ReadLine());

            Console.Write("Введите день недели (1-7, где 1 - понедельник, 7 - воскресенье): ");
            int d = int.Parse(Console.ReadLine());

            // Расчет стоимости
            double totalCost = dt * s; // Базовая стоимость

            // Применение скидки с 22:00 до 8:00
            if (t >= 22 || t < 8)
            {
                totalCost *= 0.8; // Скидка 20%
            }

            // Применение скидки в субботу или воскресенье
            if (d == 6 || d == 7) // 6 - суббота, 7 - воскресенье
            {
                totalCost *= 0.9; // Дополнительная скидка 10%
            }

            // Вывод результата
            Console.WriteLine($"Общая стоимость разговора: {totalCost:F2} руб.");
        }
    }
}
