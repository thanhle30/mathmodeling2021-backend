using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class EventViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Overview")]
        public string Body { get; set; }
        [Display(Name = "Start Date")]
        public DateTime DateStart { get; set; }
        [Display(Name = "End Date")]
        public DateTime DateEnd { get; set; }
        [Display(Name = "Image")]
        public IFormFile Image { get; set; }
    }
}
