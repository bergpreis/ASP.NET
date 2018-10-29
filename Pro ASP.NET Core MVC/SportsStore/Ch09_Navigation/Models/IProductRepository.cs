using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch09_Navigation.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
