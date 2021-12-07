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
    public class StudentController : ControllerBase
    {
        private APIContext _apiContext;

        public StudentController(APIContext apiContext)
        {
            _apiContext = apiContext;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _apiContext.Students.Take(5);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _apiContext.Students.FirstOrDefault(s => s.StudentID == id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            _apiContext.Students.Add(value);
            _apiContext.SaveChanges();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            var student = _apiContext.Students.FirstOrDefault(s => s.StudentID == id);
            if (student != null)
            {
                _apiContext.Entry<Student>(student).CurrentValues.SetValues(value);
                _apiContext.SaveChanges();
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _apiContext.Students.FirstOrDefault(s => s.StudentID == id);
            if (student != null)
            {
                _apiContext.Students.Remove(student);
                _apiContext.SaveChanges();
            }
        }
    }
}
