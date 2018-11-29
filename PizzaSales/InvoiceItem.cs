using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSales
{
    public class InvoiceItem
    {
        public Product ProductItem { get; set; } // Product line
        public int Quantity { get; set; } // how many sold

    }
}
