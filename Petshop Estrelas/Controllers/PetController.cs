using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Petshop_Estrelas.Domain;
using Petshop_Estrelas.Services.Interface;

namespace Petshop_Estrelas.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetServices _petServices;
        private readonly ILogger<PetController> _logger;
        //public PetController(IPetServices petServices, ILogger<PetController> logger)
        //{
        //    _petServices = petServices;
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        // GET: api/Pet
        //[HttpGet]
        //public List<Pet> Get()
        //{
        //    try
        //    {
        //        return _petServices.GetAll();
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, exception.Message);
        //        throw;
        //    }
            
        //}

        // GET: api/Pet/5
        //[HttpGet("{id}", Name = "Get")]
        //public Pet Get(int id)
        //{
        //    try
        //    {
        //        return _petServices.GetById(id);
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, exception.Message);
        //        throw;
        //    }
        //}

        // POST: api/Pet
        //[HttpPost]
        //public bool Post([FromBody] Pet pet)
        //{
        //    try
        //    {
        //        return _petServices.Add(pet);
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, exception.Message);
        //        throw;
        //    }
        //}

        // PUT: api/Pet/5
        //[HttpPut("{id}")]
        //public bool Put([FromBody] Pet pet)
        //{
        //    try
        //    {
        //        return _petServices.Update(pet);
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, exception.Message);
        //        throw;
        //    }
        //}

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public bool Delete(Pet pet)
        //{
        //    try
        //    {
        //        return _petServices.Delete(pet);
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, exception.Message);
        //        throw;
        //    }
            
        //}
    }
}
