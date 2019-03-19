using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutApp
{
    class UserCart
    {
        private decimal subTotal;
        private decimal shipRate;
        private decimal grandTotal;
        private decimal tax;

        public UserCart()
        {

        }

        public int ItemAmount { get; set; }

        public decimal ItemValue { get; set; }

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
                    if (ItemAmount < 3)
                        shipRate += 3.50M;
                    if (ItemAmount >= 3 && ItemAmount <= 6)
                        shipRate += 5.00M;
                    if (ItemAmount >= 7 && ItemAmount <= 10)
                        shipRate += 7.00M;
                    if (ItemAmount >= 11 && ItemAmount <= 15)
                        shipRate += 9.00M;
                    if (ItemAmount > 15)
                        shipRate += 10.00M;
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
                subTotal = ItemValue + shipRate; 
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
                grandTotal = subTotal + shipRate + Tax;
            }
        }

        public string PurchaseDetails()
        {
            return string.Format("Items Purchased: {0}\n" +
                                 "Sub Total: {1}\n" +
                                 "Shipping Charge: {2}\n" +
                                 "Sales Tax: {3}\n" +
                                 "------------\n" +
                                 "Grand Total: {4}", ItemAmount, subTotal.ToString("C2"), shipRate.ToString("C2"), tax.ToString("C2"), grandTotal.ToString("C2")); 
        }
    }    
}
