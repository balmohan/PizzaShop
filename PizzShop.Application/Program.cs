using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using PizzaShop.Repository;
using PizzaShop.Repository.Entities;
using PizzaShop.Repository.Interfaces;
using PizzaShop.Repository.Repositories;
using PizzShop.Application.Interfaces;
using PizzShop.Application.Master;
using PizzShop.Application.Models;

namespace PizzShop.Application
{
    class Program
    {
        private static IContainer Root()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserInterface>();
            builder.RegisterType<OrderMaster>().As<IOrderMaster>().InstancePerLifetimeScope();
            builder.RegisterType<RepositoryService>().As<IRepositoryService>();
            builder.RegisterType<OrderModel>().As<OrderModel>().InstancePerLifetimeScope();
            builder.RegisterType<ProductsRepository>().As<IProductsRepository>();
            builder.RegisterType<OrdersRepository>().As<IOrdersRepository>();
            builder.RegisterType<SubProductsRepository>().As<ISubProductsRepository>();
            builder.RegisterType<TransactionContainerRepository>().As<ITransactionContainerRepository>();
            builder.RegisterType<SubOrdersRepository>().As<ISubOrdersRepository>();
            return builder.Build();
        }

        static void Main(string[] args)
        {
            try
            {


                Root().Resolve<UserInterface>().FrontScreen();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}