using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ch10_CompletingTheCart.Models;

namespace Ch10_CompletingTheCart.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
