﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class MediaViewModel
    {
        public int Year { get; set; }
        [Display(Name = "Image")]
        public IFormFile Image { get; set; }
    }
}
