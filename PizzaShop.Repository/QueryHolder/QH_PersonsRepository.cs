using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.QueryHolder
{
    static class QH_PersonsRepository
    {
        public static string selectPersonById = "Select * from Persons where person_id=@0";
    }
}
