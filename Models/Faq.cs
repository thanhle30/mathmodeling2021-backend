using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Question")]
        public string Question { get; set; }
        [Display(Name = "Answer")]
        public string Answer { get; set; }
    }
}
