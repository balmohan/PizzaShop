using PizzaShop.Repository.Entities;
using PizzShop.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzShop.Application.Interfaces
{
    interface IOrderMaster
    {
        OrderModel Order { get;}
        OrderModel AddProductsToOrder(ProductModel products);
        OrderModel AddSubProductsToOrder(ProductModel products);
        OrderModel PlaceOrder();
    }
}
