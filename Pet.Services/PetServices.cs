using Petshop_Estrelas.Domain;
using Petshop_Estrelas.Repository.Interfaces;
using Petshop_Estrelas.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop_Estrelas.Services
{
    public class PetServices : IPetServices
    {
        private readonly IRepository<Pet> _repository;

        public PetServices(IRepository<Pet> repository)
        {
            _repository = repository;
        }

        public bool Add(Pet obj)
        {
            return _repository.Add(obj);
        }

        public bool Delete(Pet obj)
        {
            return _repository.Delete(obj);
        }

        public List<Pet> GetAll()
        {
            return _repository.GetAll();
        }

        public Pet GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Update(Pet obj)
        {
            return _repository.Update(obj);
        }
    }
}
