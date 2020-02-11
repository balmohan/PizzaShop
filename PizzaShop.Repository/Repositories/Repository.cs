using PetaPoco;
using PetaPoco.Extensions;
using PetaPoco.SqlKata;
using PizzaShop.Repository.Interfaces;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Repository.Repositories
{
    public class Repository<TENTITY> :BaseClass,IRepository<TENTITY> where TENTITY : class
    {
        //Primary key is considered as a id column of a table if your table have different name for primary key column you can provide
        //your own implementation by overiding this method in your repository
        public readonly Database _Database;
        public Repository()
        {
            _Database = Database;
        }
        public void Delete(TENTITY Id)
        {
            _Database.Delete<TENTITY>(Id);
        }

        public virtual TENTITY Get(int id)
        {
            var query = new Query().GenerateSelect<TENTITY>().Where("Id", id);
            return _Database.Fetch<TENTITY>(query).SingleOrDefault();
        }

        public IEnumerable<TENTITY> GetAll()
        {
            var query = new Query().GenerateSelect<TENTITY>();
            return _Database.Fetch<TENTITY>(query);
        }

        public TENTITY Insert(TENTITY entity)
        {
            if (_Database.IsNew(entity))
            {
                _Database.Insert(entity);
                return entity;
            }
            else
            {
                _Database.Update(entity);
                return entity;
            }
        }
    }
}
