using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ch08_SportsStore.Models;

namespace Ch08_SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
