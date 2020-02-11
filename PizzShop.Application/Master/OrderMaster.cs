using PizzaShop.Repository.Entities;
using PizzaShop.Repository.Interfaces;
using PizzShop.Application.Interfaces;
using PizzShop.Application.Models;
using System;
using System.Linq;

namespace PizzShop.Application.Master
{
    class OrderMaster : IOrderMaster
    {
        readonly IRepositoryService _serviceRepository;
        public OrderModel Order { get; set; }

        public OrderMaster(IRepositoryService serviceRepository,OrderModel orderModel)
        {
            _serviceRepository = serviceRepository;
            Order = orderModel;
        }
        public OrderModel AddSubProductsToOrder(ProductModel products)
        {
            if (Order.ProductModel.Count() > 0)
            {
                foreach (var item in Order.ProductModel.ToList())
                {
                    if (item.Product.Id == products.Product.Id && products.SubProduct != null)
                    {
                        item.SubProduct.AddRange(products.SubProduct);
                    }
                }
            }

            return Order;
        }
        public OrderModel AddProductsToOrder(ProductModel products)
        {
            Order.ProductModel.Add(products);
            return Order;
        }

        public OrderModel PlaceOrder()
        {
            if (Order.ProductModel.Count() > 0)
            {
                var NewTransactionContainer = _serviceRepository.TransactionContainerRepository.Insert(new TransactionContainer() { TransactionDate = DateTime.Now });
                foreach (var order in Order.ProductModel)
                {
                    Order.MyOrder = _serviceRepository.OrdersRepository.Insert(new Order() { ProductId = order.Product.Id, TransactionContainerId = NewTransactionContainer.Id });
                    if (order.SubProduct != null)
                    {
                        foreach (var suborder in order.SubProduct)
                        {
                            _serviceRepository.SubOrdersRepository.Insert(new SubOrders() { OrderId = Order.MyOrder.Id, ProductId = order.Product.Id, SubProductId = suborder.SubProductId });
                        }
                    }
                }
                return Order;
            }
            else return Order;
        }
        public OrderModel RemoveSubProductFromOrder(ProductModel productTobeRemoved)
        {
            if (Order.ProductModel.Count() > 0)
            {
                foreach (var item in Order.ProductModel.ToList())
                {
                    if (item.Product.Id == productTobeRemoved.Product.Id)
                    {
                        foreach (var subProduct in item.SubProduct.ToList())
                        {
                            foreach (var subProductTobeRemoved in productTobeRemoved.SubProduct)
                            {
                                if (subProduct.SubProductId == subProductTobeRemoved.SubProductId)
                                {
                                    item.SubProduct.Remove(subProduct);
                                }
                            }
                        }
                    }

                }
            }
            return Order;
        }
    }

}
