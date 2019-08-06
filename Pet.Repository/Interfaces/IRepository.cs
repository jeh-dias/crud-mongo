using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop_Estrelas.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        bool Add(T obj);

        List<T> GetAll();

        bool Delete(T obj);

        bool Update(T obj);

        T GetById(int id);
    }
}
