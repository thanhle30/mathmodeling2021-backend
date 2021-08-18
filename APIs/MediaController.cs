using MathModeling21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private MathModelingContext context { get; set; }
        public MediaController(MathModelingContext ctx)
        {
            context = ctx;
        }

        [HttpGet] 
        public IActionResult GetMedia()
        {
            var media = context.Media.ToList();
            return Ok(media);
        }

        [HttpGet("{year}")]
        public IActionResult GetMediaByYear(int year)
        {
            var media = context.Media.Where(m => m.Year == year).ToList();
            return Ok(media);
        } 
    }
}
