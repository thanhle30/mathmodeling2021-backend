using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class ArticleViewModel
    {
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [Display(Name = "Nội dung")]
        public string Body { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public IFormFile Image { get; set; }
        [Display(Name = "Ngày đăng")]
        public DateTime PostDate { get; set; }
        [Display(Name = "Publish bài")]
        public Boolean IsPublished { get; set; }
    }
}
