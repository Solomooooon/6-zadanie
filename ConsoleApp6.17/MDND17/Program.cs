using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sOneDivisibleBy3AndAnotherBy5(int A, int B, int C, int D)
            {
                return (A % 3 == 0 && (B % 5 == 0 || C % 5 == 0 || D % 5 == 0)) ||
                       (B % 3 == 0 && (A % 5 == 0 || C % 5 == 0 || D % 5 == 0)) ||
                       (C % 3 == 0 && (A % 5 == 0 || B % 5 == 0 || D % 5 == 0)) ||
                       (D % 3 == 0 && (A % 5 == 0 || B % 5 == 0 || C % 5 == 0));
            }
        }
    }
}
