using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PostDate { get; set; }
        public IFormFile[] Images { get; set; }
    }
}
