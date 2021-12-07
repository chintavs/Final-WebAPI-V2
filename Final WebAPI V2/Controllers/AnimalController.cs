using Final_WebAPI_V2.Context;
using Final_WebAPI_V2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_WebAPI_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private APIContext _apiContext;

        public AnimalController(APIContext apiContext)
        {
            _apiContext = apiContext;
        }

        // GET: api/<AnimalController>
        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _apiContext.Animals.Take(5);
        }

        // GET api/<AnimalController>/5
        [HttpGet("{id}")]
        public Animal Get(int id)
        {
            return _apiContext.Animals.FirstOrDefault(s => s.AnimalId == id);
        }

        // POST api/<AnimalController>
        [HttpPost]
        public void Post([FromBody] Animal value)
        {
            _apiContext.Animals.Add(value);
            _apiContext.SaveChanges();
        }

        // PUT api/<AnimalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal value)
        {
            var animal = _apiContext.Animals.FirstOrDefault(s => s.AnimalId == id);
            if (animal != null)
            {
                _apiContext.Entry<Animal>(animal).CurrentValues.SetValues(value);
                _apiContext.SaveChanges();
            }
        }

        // DELETE api/<AnimalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var animal = _apiContext.Animals.FirstOrDefault(s => s.AnimalId == id);
            if (animal != null)
            {
                _apiContext.Animals.Remove(animal);
                _apiContext.SaveChanges();
            }
        }
    }
}
