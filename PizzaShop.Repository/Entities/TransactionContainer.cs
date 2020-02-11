using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Entities
{
    [TableName("TransactionContainer")]
    public class TransactionContainer
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
