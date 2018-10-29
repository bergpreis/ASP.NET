using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch09_Navigation.Models
{
    public class CartLine
    {
        public int CarLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
