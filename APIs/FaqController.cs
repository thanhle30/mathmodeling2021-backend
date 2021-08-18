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
    public class FaqController : ControllerBase
    {
        private MathModelingContext context { get; set; }
        public FaqController(MathModelingContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetFaq()
        {
            var faq = context.Faq.ToList();
            return Ok(faq);
        }
    }
}
