using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Entities
{
    [TableName("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TransactionContainerId { get; set; }

    }
}
