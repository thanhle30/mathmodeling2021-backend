using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public int Year { get; set; }
    }
}
