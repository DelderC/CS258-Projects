using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutApp
{
    class UserCart
    {
        // Class data types
        private decimal subTotal;
        private decimal shipRate;
        private decimal grandTotal;
        private decimal tax;
        private int itemAmount;
        private decimal itemValue;
        // UserCart constructor
        public UserCart()
        {

        }
        // Properties for values
        public int ItemAmount
        {
            get
            {
                return itemAmount;
            }
            set
            {
                itemAmount = value;
            }
        }

        public decimal ItemValue
        {
            get
            {
                return itemValue;
            }
            set
            {
                itemValue = value;
            }
        }

        public decimal ShipRate
        {
            get
            {
                return shipRate;
            }
            set
            {
                if (subTotal >= 100.00M)
                    shipRate = 0.00M;
                else
                {
                    if (itemAmount < 3)
                        shipRate = 3.50M;
                    if (itemAmount >= 3 && itemAmount <= 6)
                        shipRate = 5.00M;
                    if (itemAmount >= 7 && itemAmount <= 10)
                        shipRate = 7.00M;
                    if (itemAmount >= 11 && itemAmount <= 15)
                        shipRate = 9.00M;
                    if (itemAmount > 15)
                        shipRate = 10.00M;
                }
            }
        }

        public decimal SubTotal
        {
            get
            {
                return subTotal;
            }
            set
            {
                subTotal = itemValue + shipRate; 
            }
        }

        public decimal Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = subTotal * 0.0775M;
            }
        }

        public decimal GrandTotal
        {
            get
            {
                return grandTotal;
            }
            set
            {
                grandTotal = subTotal + Tax;
            }
        }
        // Display method for receipt
        public string PurchaseDetails()
        {
            return string.Format("\nTotal Item Cost: {0} : " + itemAmount + " items\n" + 
                                 "Shipping Charge: {1}\n" +
                                 "Sub Total: {2}\n" +
                                 "Sales Tax: {3}\n" +
                                 "------------\n" +
                                 "Grand Total: {4}", itemValue.ToString("C2"), shipRate.ToString("C2"), subTotal.ToString("C2"), tax.ToString("C2"), grandTotal.ToString("C2")); 
        }
    }    
}
