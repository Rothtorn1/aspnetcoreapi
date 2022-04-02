using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapi.Modeller
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CourseTitle { get; set; }

       
    }
}
