using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PostDate { get; set; }
        public string ImagesStr { get; set; }
        [NotMapped]
        public List<string> Images {
            get
            {
                if (ImagesStr != null && ImagesStr != "")
                {
                    return ImagesStr.Split(",").ToList();
                } else
                {
                    return new List<string>();
                }            
            }
        } 
    }
}
