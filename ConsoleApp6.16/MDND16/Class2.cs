using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND16
{
    internal class Class2
    {
        class Program
        {
            static void Main()
            {
                // Создаем объект класса EvenNumberChecker
                EvenNumberChecker checker = new EvenNumberChecker(3, 4, 6, 7);

                // Выводим результат
                checker.PrintResult();
            }
        }
    }
}
