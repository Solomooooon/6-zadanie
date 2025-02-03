using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND19
{
    public class SalaryCalculator
    {
        public decimal CalculateExperienceBonus(int experience)
        {
            if (experience >= 5 && experience < 10)
            {
                return 0.02m; 
            }
            else if (experience >= 10 && experience <= 20)
            {
                return 0.10m; 
            }
            else
            {
                return 0.00m; 
            }
        }
    }
}
