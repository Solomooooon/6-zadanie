 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDND19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int yearsOfExperience = 12;
            double salary = 50000; 
            double bonus = CalculateSalaryBonus(yearsOfExperience, salary);
            Console.WriteLine($"Надбавка к зарплате: {bonus} рублей");
        }

        static double CalculateSalaryBonus(int yearsOfExperience, double salary)
        {
            if (yearsOfExperience >= 5 && yearsOfExperience < 10)
            {
                return salary * 0.02; 
            }
            else if (yearsOfExperience >= 10 && yearsOfExperience < 20)
            {
                return salary * 0.10; 
            }
            return 0;
        }
    }
}
