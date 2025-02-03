using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND17
{
    internal class CCLASS1
    {
        
    static void Main(string[] args)
        {
            int A = 9;
            int B = 10;
            int C = 7;
            int D = 8;

            bool result = IsOneDivisibleBy3AndAnotherBy5(A, B, C, D);
            Console.WriteLine(result); // Вывод: true, так как A делится на 3, а B на 5
        }

        static bool IsOneDivisibleBy3AndAnotherBy5(int A, int B, int C, int D)
        {
            return (A % 3 == 0 && (B % 5 == 0 || C % 5 == 0 || D % 5 == 0)) ||
                   (B % 3 == 0 && (A % 5 == 0 || C % 5 == 0 || D % 5 == 0)) ||
                   (C % 3 == 0 && (A % 5 == 0 || B % 5 == 0 || D % 5 == 0)) ||
                   (D % 3 == 0 && (A % 5 == 0 || B % 5 == 0 || C % 5 == 0));
        }
    }
}

