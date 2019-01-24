/*
 Programmer: Devin Elder
 Date: 1/20/2019
 Description: This program calculates the total net proceeds of candy bar sales after subtracting total costs and commissions.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySales
{
    class Program
    {
        static void Main(string[] args)
        {
            string clubName;
            string str_casesSold;
            int i_casesSold;
            const decimal salePrice = 0.75m;
            const decimal caseCost = 5.00m;
            const int barsPerCase = 12;
            const double commissionRate = 0.1;

            // Asking for user input
            Console.Write("Please enter club name: ");
            clubName = Console.ReadLine();
            Console.Write("Please enter number of cases sold: ");
            str_casesSold = Console.ReadLine();
            i_casesSold = int.Parse(str_casesSold);

            // Calculations
            decimal calculatedSales = i_casesSold * barsPerCase * salePrice;
            decimal calculatedCost = i_casesSold * caseCost;
            decimal commission = (calculatedSales - calculatedCost) * Convert.ToDecimal(commissionRate);
            decimal netProceeds = calculatedSales - calculatedCost - commission;
            Console.Clear();

            // Displayed totals of input values
            Console.WriteLine("The " + clubName + " computer club produced $" + calculatedSales + " from their candy sales project.\n" +
                              "The total cost of the candy was $" + calculatedCost + "\n" +
                              "The student government commission amount was " + commission.ToString("C2") + ".\n" +
                              "The net proceeds equals to " + netProceeds.ToString("C2") +".");

            

            
        }

    }
}
