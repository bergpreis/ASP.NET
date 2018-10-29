using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ch10_CompletingTheCart.Models;

namespace Ch10_CompletingTheCart.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
