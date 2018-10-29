using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ch10_CompletingTheCart.Infrastructure;
using Ch10_CompletingTheCart.Models;
using Ch10_CompletingTheCart.Models.ViewModels;
using Microsoft.AspNetCore.Session;

namespace Ch10_CompletingTheCart.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private Cart cart;

        public CartController(IProductRepository Repository, Cart cartService)
        {
            repository = Repository;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
