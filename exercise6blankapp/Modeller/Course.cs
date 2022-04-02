using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapi.Modeller
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string CourseTitle { get; set; }



        

    }
}
