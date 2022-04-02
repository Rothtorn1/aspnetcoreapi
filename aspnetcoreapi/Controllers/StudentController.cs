using aspnetcoreapi.Modeller;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ClassContext _classContext;

        public StudentController(ClassContext classContext)
        {
            _classContext = classContext;
        }
        // GET: api/Students
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _classContext.Students;
        }

        // GET api/Students/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return _classContext.Students.SingleOrDefault(x => x.StudentId == id);
        }

        // POST api/Students
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _classContext.Students.Add(student);
            _classContext.SaveChanges();
        }

        // PUT api/Students/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            student.StudentId = id;
            _classContext.Students.Update(student);
            _classContext.SaveChanges();
        }

        // DELETE api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _classContext.Students.FirstOrDefault(x => x.StudentId == id);
            if (item != null)
            {
                _classContext.Students.Remove(item);
                _classContext.SaveChanges();
            }
        }
    }
}




