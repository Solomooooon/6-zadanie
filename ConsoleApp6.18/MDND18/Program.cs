using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double purchaseAmount = 15000;
            double finalPrice = CalculateDiscount(purchaseAmount);
            Console.WriteLine($"Итоговая стоимость покупки: {finalPrice} рублей");
        }

        static double CalculateDiscount(double purchaseAmount)
        {
            if (purchaseAmount > 10000 && purchaseAmount < 20000)
            {
                return purchaseAmount * 0.95; 
            }
            else if (purchaseAmount >= 20000 && purchaseAmount < 50000)
            {
                return purchaseAmount * 0.90; 
            }
            return purchaseAmount; 
        }
    }
}
