using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND16
{
    public class EvenNumberChecker
    {
        private int A;
        private int B;
        private int C;
        private int D;

        public EvenNumberChecker(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private int CountEvenNumbers()
        {
            int evenCount = 0;

            if (IsEven(A)) evenCount++;
            if (IsEven(B)) evenCount++;
            if (IsEven(C)) evenCount++;
            if (IsEven(D)) evenCount++;

            return evenCount;
        }
        public bool ExactlyTwoEven()
        {
            return CountEvenNumbers() == 2;
        }
    }
}


