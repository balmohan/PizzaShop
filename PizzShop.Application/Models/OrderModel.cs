using PizzaShop.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzShop.Application.Models
{
    class OrderModel
    {
        public Order MyOrder { get; set; }
        public OrderModel()
        {
            ProductModel = new List<ProductModel>();
        }
        public IList<ProductModel> ProductModel { get; set; }
    }
}
