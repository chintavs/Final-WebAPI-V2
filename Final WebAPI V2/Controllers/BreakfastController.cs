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
    public class BreakfastController : ControllerBase
    {
        private APIContext _apiContext;

        public BreakfastController(APIContext apiContext)
        {
            _apiContext = apiContext;
        }

        // GET: api/<BreakfastController>
        [HttpGet]
        public IEnumerable<Breakfast> Get()
        {
            return _apiContext.Breakfasts.Take(5);
        }

        // GET api/<BreakfastController>/5
        [HttpGet("{id}")]
        public Breakfast Get(int id)
        {
            return _apiContext.Breakfasts.FirstOrDefault(s => s.PersonID == id);
        }

        // POST api/<BreakfastController>
        [HttpPost]
        public void Post([FromBody] Breakfast value)
        {
            _apiContext.Breakfasts.Add(value);
            _apiContext.SaveChanges();
        }

        // PUT api/<BreakfastController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Breakfast value)
        {
            var Breakfast = _apiContext.Breakfasts.FirstOrDefault(s => s.PersonID == id);
            if (Breakfast != null)
            {
                _apiContext.Entry<Breakfast>(Breakfast).CurrentValues.SetValues(value);
                _apiContext.SaveChanges();
            }
        }

        // DELETE api/<BreakfastController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Breakfast = _apiContext.Breakfasts.FirstOrDefault(s => s.PersonID == id);
            if (Breakfast != null)
            {
                _apiContext.Breakfasts.Remove(Breakfast);
                _apiContext.SaveChanges();
            }
        }
    }
}
