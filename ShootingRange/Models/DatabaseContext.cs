using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ShootingRange.Models
{
    class DatabaseContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DatabaseContext() : base("DefaultConnection")
        {
           
        }
    }
}
