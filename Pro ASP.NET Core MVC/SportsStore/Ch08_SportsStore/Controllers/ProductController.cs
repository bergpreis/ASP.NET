using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ch08_SportsStore.Models;
using Ch08_SportsStore.Models.ViewModels;

namespace Ch08_SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        private int PageSize = 4;

        public ProductController(IProductRepository Repository) => repository = Repository;

        public ViewResult List(int productPage = 1) 
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}
