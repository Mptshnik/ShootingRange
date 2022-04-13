using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Models
{
    public enum Roles
    {
        Admin = 0
    }

    public class Employee
    {
        [Key] public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int? Role { get; set; }
        public int? PostID { get; set; }
        public Post Post { get; set; }
    }
}
