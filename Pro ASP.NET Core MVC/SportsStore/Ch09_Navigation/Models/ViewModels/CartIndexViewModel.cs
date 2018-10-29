using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ch09_Navigation.Models;

namespace Ch09_Navigation.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
