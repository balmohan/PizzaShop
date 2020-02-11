using PizzaShop.Repository.Interfaces;
using PizzaShop.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Repositories
{
    public class RepositoryService : IRepositoryService
    {

        public ISubProductsRepository SubProductsRepository { get; set; }
        public ITransactionContainerRepository TransactionContainerRepository { get; set; }
        public ISubOrdersRepository SubOrdersRepository { get; set; }
        public IOrdersRepository OrdersRepository { get; set; }

        public IProductsRepository ProductsRepository { get; set; }

        public RepositoryService(IProductsRepository productsRepository, ISubProductsRepository subProductsRepository, IOrdersRepository ordersRepository, ISubOrdersRepository subOrdersRepository,ITransactionContainerRepository transactionContainerRepository)
        {
            ProductsRepository = productsRepository;
            SubOrdersRepository = subOrdersRepository;
            SubProductsRepository = subProductsRepository;
            OrdersRepository = ordersRepository;
            TransactionContainerRepository = transactionContainerRepository;
        }

    }
}
