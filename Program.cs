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
                counter++;

                // Checks to see if input it an actual number
                if (!decimal.TryParse(_itemValue, out decimal itemValue) && !string.IsNullOrEmpty(_itemValue))
                {
                    Console.WriteLine("You have entered no value or an invalid number. Please try again.");
                    counter--;
                }   
                // Checks
                if (string.IsNullOrEmpty(_itemValue))
                {
                    counter--;
                    Console.Write("You have entered no value. Do you wish to enter more prices? (Y/N): ");
                    _itemValue = Console.ReadLine();
                    c1.ItemAmount = counter;
                    c1.ItemValue = itemTotal;
                    c1.SubTotal = 0M;
                    c1.ShipRate = 0M;                    
                    c1.Tax = 0M;
                    c1.GrandTotal = 0M;
                    if (_itemValue == "y" || _itemValue == "Y")
                        continue;
                    else if (c1.SubTotal >= 90.00M && c1.SubTotal < 100.00M)
                    {

                        decimal deal = 100.00M - c1.SubTotal;

                        Console.Clear();
                        Console.Write("Whoa! You are {0} away from free shipping! Would you like to add more items? (Y/N): ", deal.ToString("C2"));
                        _itemValue = Console.ReadLine();
                        if (_itemValue == "y" || _itemValue == "Y")
                            continue;
                        else
                        {
                            counter--;
                            c1.ItemAmount = counter;
                            break;
                        }
                    }
                    else
                    {
                        counter--;
                        c1.ItemAmount = counter;
                        break;
                    }
                        
                    
                }
                itemTotal += itemValue;
            }
            while (Exit == false);
            Console.Clear();
            Console.WriteLine(c1.PurchaseDetails());            
        }
    }
}
