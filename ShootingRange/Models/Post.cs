using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Models
{
    public class Post
    {
        [Key] public int ID { get; set; }
        public string Name { get; set; }
    }
}
