using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._24
{
    class Class1
    {
        public bool E(bool A, bool B, bool C)
        {
            return A || (!B && !(A && !C));
        }
        public void P()
        {
            Console.WriteLine("A | B | C | результат");

            for (int a = 0; a <= 1; a++)
            {
                for (int b = 0; b <= 1; b++)
                {
                    for (int c = 0; c <= 1; c++)
                    {

                        bool A = a == 1;
                        bool B = b == 1;
                        bool C = c == 1;


                        bool result = A || (!B && !(A && !C));

                    }
                }
            }
        }
    }
}