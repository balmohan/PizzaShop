using PizzaShop.Repository.Entities;
using PizzaShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Repositories
{
    public class ProductsRepository:Repository<Product>,IProductsRepository
    {

    }
}
