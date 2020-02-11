using PizzaShop.Repository;
using PizzaShop.Repository.Entities;
using PizzaShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzShop.Application
{
    class Seeder
    {
        public Seeder(IRepositoryService repositoryService)
        {
            //check if data present else feed some test records
            if (repositoryService.ProductsRepository.GetAll().Count() == 0)
            {
                List<Product> products = new List<Product>
                {
                    new Product(){ProductName="Pizza",BasePrice=100},
                    new Product(){ProductName="Sandwich",BasePrice=50}
                };
                foreach (var item in products)
                {
                    if (item.ProductName=="Pizza")
                    {
                        repositoryService.ProductsRepository.Insert(item);
                        if (repositoryService.SubProductsRepository.GetAll().Count()==00)
                        {
                            var SubProductsOfPizza = new List<SubProduct>()
                            {
                                new SubProduct(){Name="Pizza Toppings",ProductId=item.Id,Price=10},
                                new SubProduct(){Name="Coke",ProductId=item.Id,Price=15}
                            };
                            foreach (var subProduct in SubProductsOfPizza)
                            {
                                repositoryService.SubProductsRepository.Insert(subProduct);
                            }
                        }
                    }
                    else
                    {
                        repositoryService.ProductsRepository.Insert(item);
                    }
                }
            }


        }
    }
}
