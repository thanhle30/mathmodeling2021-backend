using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    [NotMapped]
    public class Status
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
