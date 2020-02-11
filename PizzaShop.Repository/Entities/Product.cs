using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Entities
{
    [TableName("Products")]
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal BasePrice { get; set; }
    }
}
