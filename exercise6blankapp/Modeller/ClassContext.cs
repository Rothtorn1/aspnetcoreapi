using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapi.Modeller
{
    public class ClassContext : DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
