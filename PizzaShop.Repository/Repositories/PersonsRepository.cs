using PetaPoco.Extensions;
using PetaPoco.SqlKata;
using PizzaShop.Repository.Entities;
using PizzaShop.Repository.QueryHolder;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Repositories
{
    public sealed class PersonsRepository:Repository<Person>
    {
        public override Person Get(int id)
        {
            return _Database.Fetch<Person>(QH_PersonsRepository.selectPersonById, id).FirstOrDefault();   
        }
    }
}
