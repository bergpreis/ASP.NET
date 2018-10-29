using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ch10_CompletingTheCart.Models;

namespace Ch10_CompletingTheCart.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository Repository)
        {
            repository = Repository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
