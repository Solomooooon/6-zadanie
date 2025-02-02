using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я6
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Введите сумму вклада: ");
            double depositAmount = double.Parse(Console.ReadLine());

            
            double interestRate;
            if (depositAmount < 50000)
            {
                interestRate = 0.16; 
            }
            else if (depositAmount >= 50000 && depositAmount <= 100000)
            {
                interestRate = 0.18; 
            }
            else
            {
                
                interestRate = 0.20; 
            }

            
            double totalPayout = depositAmount * (1 + interestRate);

            
            Console.WriteLine($"Сумма выплат по депозиту: {totalPayout:F2} руб.");
        }
    }
}
