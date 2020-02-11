using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Entities
{
    [TableName("SubProducts")]
    [PrimaryKey("Id")]
    public class SubProduct
    {
        [Column("Id")]
        public int SubProductId { get; set; }
        public string Name { get; set; }
        [Column("ProductId")]
        public int ProductId { get; set; }
        public decimal Price { get; set; }
    }
}
