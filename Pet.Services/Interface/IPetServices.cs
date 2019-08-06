using Petshop_Estrelas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop_Estrelas.Services.Interface
{
    public interface IPetServices
    {
        bool Add(Pet obj);

        List<Pet> GetAll();

        bool Delete(Pet obj);

        bool Update(Pet obj);

        Pet GetById(int id);
    }
}
