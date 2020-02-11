using PizzaShop.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Interfaces
{
    public interface IRepositoryService
    {
        IProductsRepository ProductsRepository { get; set; }
        ISubProductsRepository SubProductsRepository { get; set; }
        ITransactionContainerRepository TransactionContainerRepository { get; set; }
        ISubOrdersRepository  SubOrdersRepository { get; set; }
        IOrdersRepository OrdersRepository { get; set; }

    }
}
