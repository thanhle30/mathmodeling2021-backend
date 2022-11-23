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
        [Display(Name = "Sự kiện lớn")]
        public Boolean IsBigEvent { get; set; }

        [Display(Name = "Mô tả ngắn gọn")]
        public string Brief { get; set; }
        [Display(Name = "Thông tin chi tiết")]
        public string Body { get; set; }
        [Display(Name = "Địa điểm")]
        public string Location { get; set; }
        [Display(Name = "Start Date")]
        public DateTime DateStart { get; set; }
        [Display(Name = "End Date")]
        public DateTime DateEnd { get; set; }
        [Display(Name = "Link đăng ký")]
        public string SignUpLink { get; set; }
        [Display(Name = "Image")]
        public IFormFile Image { get; set; }
    }
}
