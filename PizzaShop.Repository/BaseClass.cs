using PetaPoco;
using PizzaShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository
{
public class BaseClass
{
        private readonly string _connectionstring;
        public BaseClass()
        {
            _connectionstring = "PizzaShopConnectionString";
        }
        protected Database Database
        {
            get
            {
                return new Database(_connectionstring);
            }
            private set { }
        }

        public void Dispose()
        {
            ((IDisposable)Database).Dispose();
        }
    }
}
