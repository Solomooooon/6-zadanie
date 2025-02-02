using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._26
{
    class class1
    {
        private int N;

        public class1(int n)
        {
            N = n;
        }

        public void CheckCondition()
        {
            if (N % 5 == 0 && N % 2 != 0 && N % 3 != 0)
            {
                Console.WriteLine("Число N удовлетворяет условию.");
            }
            else
            {
                Console.WriteLine("Число N не удовлетворяет условию.");
            }
        }
    }
}
