using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name = "Role")]
        public string Role { get; set; }
        [Display(Name="Image")] 
        public string Image { get; set; }
        [Display(Name = "Gif")]
        public string Gif { get; set; }
        [Display(Name = "Facebook")]
        public string FacebookUrl { get; set; }
        [Display(Name = "Instagram")]
        public string InstagramUrl { get; set; }
        [Display(Name = "LinkedIn")]
        public string LinkedInUrl { get; set; }
    }
}
