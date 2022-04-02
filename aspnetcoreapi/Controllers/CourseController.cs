using aspnetcoreapi.Modeller;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace aspnetcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class CoursesController : ControllerBase
    {
        private readonly ClassContext _classContext;

        public CoursesController(ClassContext classContext)
        {
                _classContext = classContext;
        }
        // GET: api/Courses
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _classContext.Courses;
        }

        // GET api/Course/5
        [HttpGet("{id}", Name = "Get_1")]
        public Course Get(int id)
        {
            return _classContext.Courses.SingleOrDefault(x => x.CourseId == id);
        }

        // POST api/Courses
        [HttpPost]
        public void Post([FromBody] Course course)
        {
                _classContext.Courses.Add(course);
                _classContext.SaveChanges();
        }

        // PUT api/Courses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course course)
        {
            course.CourseId = id;
                _classContext.Courses.Update(course);
                _classContext.SaveChanges();
        }

        // DELETE api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _classContext.Courses.FirstOrDefault(x => x.CourseId == id);
            if (item != null)
            {
                    _classContext.Courses.Remove(item);
                    _classContext.SaveChanges();
            }
        }
    }

    }

