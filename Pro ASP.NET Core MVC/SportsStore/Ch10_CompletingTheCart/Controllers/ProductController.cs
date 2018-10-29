﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ch10_CompletingTheCart.Models;
using Ch10_CompletingTheCart.Models.ViewModels;

namespace Ch10_CompletingTheCart.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        private int PageSize = 4;

        public ProductController(IProductRepository Repository) => repository = Repository;

        public ViewResult List(string category, int productPage = 1) 
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            });
    }
}