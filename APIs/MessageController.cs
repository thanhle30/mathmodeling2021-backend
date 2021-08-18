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
    public class MessageController : ControllerBase
    {
        private MathModelingContext context;
        public MessageController(MathModelingContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetMessages()
        {
            var messages = context.Messages.ToList();
            return Ok(messages);
        }

        [HttpPost]
        public IActionResult AddMessage([FromBody] Message message)
        {
            try
            {
                message.PostDate = DateTime.Now;
                context.Add(message);
                context.SaveChanges();
                return Ok();
            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
