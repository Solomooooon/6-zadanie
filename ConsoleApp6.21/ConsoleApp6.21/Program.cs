using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._21
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стаж работы по специальности (в годах): ");
            int ZXC = int.Parse(Console.ReadLine());
            CXZ ZXCV = new CXZ(ZXC);
            int ZX = ZXCV.ZXCV();
            Console.WriteLine($"Коэффициент учета стажа работы: {ZX}");
        }
    }
}
