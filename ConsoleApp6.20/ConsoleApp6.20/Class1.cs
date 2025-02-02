using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._20
{
    class Class1
    {
            public bool E(bool X, bool Y, bool Z)
            {
                return X || !((!Y) && Z) || Y;
            }
         public void P()
         {
                Console.WriteLine("X | Y | Z | результат");

                for (int x = 0; x <= 1; x++)
                {
                    for (int y = 0; y <= 1; y++)
                    {
                        for (int z = 0; z <= 1; z++)
                        {
                            bool X = x == 1;
                            bool Y = y == 1;
                            bool Z = z == 1;

                            bool result = E(X, Y, Z);

                            Console.WriteLine($"{X} | {Y} | {Z} | {result}");
                        }
                    }
                 }
         }
    }
}
