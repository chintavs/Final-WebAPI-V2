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
    public class TeamController : ControllerBase
    {
        private APIContext _apiContext;

        public TeamController(APIContext apiContext)
        {
            _apiContext = apiContext;
        }

        // GET: api/<TeamController>
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return _apiContext.Teams.Take(5);
        }

        // GET api/<TeamController>/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return _apiContext.Teams.FirstOrDefault(s => s.MemberId == id);
        }

        // POST api/<TeamController>
        [HttpPost]
        public void Post([FromBody] Team value)
        {
            _apiContext.Teams.Add(value);
            _apiContext.SaveChanges();
        }

        // PUT api/<TeamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var team = _apiContext.Teams.FirstOrDefault(s => s.MemberId == id);
            if (team != null)
            {
                _apiContext.Entry<Team>(team).CurrentValues.SetValues(value);
                _apiContext.SaveChanges();
            }
        }

        // DELETE api/<TeamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var team = _apiContext.Teams.FirstOrDefault(s => s.MemberId == id);
            if (team != null)
            {
                _apiContext.Teams.Remove(team);
                _apiContext.SaveChanges();
            }
        }
    }
}
