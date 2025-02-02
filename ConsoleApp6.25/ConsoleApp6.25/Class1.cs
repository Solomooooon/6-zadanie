using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._25
{
    class class1
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public class1(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public bool CheckCondition()
        {
            bool isDivisibleBy7 = A % 7 == 0 || B % 7 == 0 || C % 7 == 0 || D % 7 == 0;
           
            bool hasOddNumber = (A % 2 != 0 && (B % 7 == 0 || C % 7 == 0 || D % 7 == 0)) ||
                                (B % 2 != 0 && (A % 7 == 0 || C % 7 == 0 || D % 7 == 0)) ||
                                (C % 2 != 0 && (A % 7 == 0 || B % 7 == 0 || D % 7 == 0)) ||
                                (D % 2 != 0 && (A % 7 == 0 || B % 7 == 0 || C % 7 == 0));
           
            return isDivisibleBy7 && hasOddNumber;
        }
    }
}
