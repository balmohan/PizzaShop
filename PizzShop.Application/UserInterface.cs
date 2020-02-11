using PizzaShop.Repository.Entities;
using PizzaShop.Repository.Interfaces;
using PizzaShop.Repository.Repositories;
using PizzShop.Application.Interfaces;
using PizzShop.Application.Master;
using PizzShop.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzShop.Application
{
    class UserInterface
    {
        IRepositoryService _repositoryService { get; set; }
        IOrderMaster _orderMaster;
        public UserInterface(IRepositoryService repositoryService, IOrderMaster orderMaster)
        {
            _repositoryService = repositoryService;
            _orderMaster = orderMaster;
            new Seeder(_repositoryService);
        }
        public void FrontScreen()
        {
            while (true)
            {
                Console.WriteLine("Please select the option : \n 1 Create New Order \n 2 Clear Cart \n 3 Submit Order");
                int UserSelectedOption = int.Parse(Console.ReadLine());
                switch (UserSelectedOption)
                {
                    case 1:
                        {
                            Console.Clear();
                            var Product = _repositoryService.ProductsRepository.Get(4);
                            _orderMaster.AddProductsToOrder(new ProductModel() { Product = Product });
                            _orderMaster.AddSubProductsToOrder(new ProductModel() { Product = Product, SubProduct = new List<SubProduct>() { _repositoryService.SubProductsRepository.Get(3) } });
                            _orderMaster.AddProductsToOrder(new ProductModel() { Product = Product });

                            Console.WriteLine("Your Order details");
                            var totalCost = 0.00M;
                            foreach (var order in _orderMaster.Order.ProductModel)
                            {
                                totalCost += order.Product.BasePrice;
                                Console.WriteLine(order.Product.ProductName + "-- $" + order.Product.BasePrice);
                                foreach (var subProduct in order.SubProduct)
                                {
                                    Console.WriteLine(" -----" + subProduct.Name + " $" + subProduct.Price);
                                    totalCost += subProduct.Price;

                                }
                            }
                            Console.WriteLine("Order total cost=" + totalCost);
                            Console.WriteLine("_____________________________________");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            _orderMaster.Order.ProductModel.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            var Order = _orderMaster.PlaceOrder();
                            if (Order.MyOrder != null)
                            {
                                Console.WriteLine("Your Order have been submitted successfully Your order Id is:{0}", Order.MyOrder.TransactionContainerId);
                            }
                            else
                            {
                                Console.WriteLine("Your order is empty please add some products before placing order");
                            }
                            break;
                        }
                }
            }
        }
    }
}
