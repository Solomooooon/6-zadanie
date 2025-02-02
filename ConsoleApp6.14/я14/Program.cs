using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я14
{
    internal class Program
    {
        static void Main()
        {
            // Перебираем все возможные значения X, Y, Z
            bool[] values = { false, true };

            Console.WriteLine("X\tY\tZ\tResult");
            Console.WriteLine("-------------------------");

            foreach (bool X in values)
            {
                foreach (bool Y in values)
                {
                    foreach (bool Z in values)
                    {
                        // Вычисляем выражение
                        bool result = !(!X && Y) || (X && !Z);

                        // Выводим результат
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{result}");
                    }
                }
            }
        }
    }
}
