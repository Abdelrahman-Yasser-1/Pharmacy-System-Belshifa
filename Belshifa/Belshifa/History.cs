using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa
{
    public class History
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public string ProductUsage { get; set; }
        public string date { get; set; }

        public History(int productID, int userID, int amount, int price, string productName, string productUsage, string date)
        {
            ProductID = productID;
            UserID = userID;
            Amount = amount;
            Price = price;
            ProductName = productName;
            ProductUsage = productUsage;
            this.date = date;
        }

        public History()
        {
        }
    }
}
