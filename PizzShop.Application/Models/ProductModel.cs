using PizzaShop.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzShop.Application.Models
{
    class ProductModel
    {
        public ProductModel()
        {
            SubProduct = new List<SubProduct>();
        }
        public Product Product { get; set; }
        public List<SubProduct> SubProduct { get; set; }
    }
}
