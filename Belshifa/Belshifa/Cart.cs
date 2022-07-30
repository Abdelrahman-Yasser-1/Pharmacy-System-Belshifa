using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa
{
    public class Cart
    {

        public int ProductUserID { get; set; }
        public int ProductAmount { get; set; }

        public Product Product { get; set; }
        public Cart(int productUserID, int productAmount,Product product)
        {
            ProductUserID = productUserID;
            ProductAmount = productAmount;
            Product = product;
        }

        public Cart()
        {
        }
    }
}
