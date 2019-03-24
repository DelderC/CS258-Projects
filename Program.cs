/* Programmer: Devin Elder
   Date:       18/03/2019
   Description: This program allows users to enter prices and get a receipt for them.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutApp
{
    class TestValue
    {
        static void Main(string[] args)
        {
            // Declaring value types
            var Exit = false;
            int counter = 1;
            string _itemValue;
            decimal itemTotal = 0M;

            // Initial Instructions
            Console.WriteLine("Thank you for using our store! Sub Totals (before tax) of $100.00 or more get free shipping!\n" +
                              "Please input price of items below. Enter no value for total.\n");
            // Instantiate UserCart Object
            UserCart c1 = new UserCart();

            // Do While Loop
            do
            {
                Console.Write("Item " + counter + ": ");
                _itemValue = Console.ReadLine();

                // Checks to see if input it an actual number
                if (!decimal.TryParse(_itemValue, out decimal itemValue) && !string.IsNullOrEmpty(_itemValue))
                {
                    Console.WriteLine("You have entered no value or an invalid number. Please try again.");
                    counter--;
                }
                // Checks if user wishes to get total
                if (string.IsNullOrEmpty(_itemValue))
                {
                    // Calls c1 set properties
                    c1.ItemAmount = counter;
                    c1.ItemValue = itemTotal;
                    c1.SubTotal = 0M;
                    c1.ShipRate = 0M;
                    // Checks if user is "this many" dollars away from free shipping
                    if (c1.SubTotal >= 90.00M && c1.SubTotal < 100.00M)
                    {
                        decimal deal = 100.00M - c1.SubTotal;

                        Console.Clear();
                        Console.Write("Whoa! You are {0} away from free shipping! Would you like to add more items? (Y/N): ", deal.ToString("C2"));
                        _itemValue = Console.ReadLine();
                        if ((_itemValue == "y") || _itemValue == "Y")
                            continue;
                        else
                        {
                            counter--;
                            c1.ItemAmount = counter;
                            c1.ShipRate = 0M;
                            c1.SubTotal = 0M;
                            c1.Tax = 0M;
                            c1.GrandTotal = 0M;
                            break;
                        }
                    }
                    else 
                    {
                        Console.Write("You have entered no value. Would you like to add more items? ('Y' to add more items/'N' to get total): ");
                        _itemValue = Console.ReadLine();
                        if ((_itemValue == "y") || _itemValue == "Y")
                        {
                            counter--;
                            continue;
                        }                                                                         
                        else
                        {
                            counter--;
                            c1.ItemAmount = counter;
                            c1.ShipRate = 0M;
                            c1.SubTotal = 0M;
                            c1.Tax = 0M;
                            c1.GrandTotal = 0M;
                            break;
                        }
                    }
                }
                itemTotal += itemValue;
                counter++;

            } while (Exit == false);

            // Displays receipt for user
            Console.Clear();
            Console.WriteLine(c1.PurchaseDetails());
        }
    }
}
