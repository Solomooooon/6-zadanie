using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND18
{
    public class PurchaseCalculator
    {
        public double CalculateTotalPrice(double initialPrice)
        {
            if (initialPrice > 10000 && initialPrice < 20000)
            {
                return initialPrice * 0.95;
            }
            else if (initialPrice >= 20000 && initialPrice < 50000)
            {
                return initialPrice * 0.90;
            }
            return initialPrice;
        }
    }
}
