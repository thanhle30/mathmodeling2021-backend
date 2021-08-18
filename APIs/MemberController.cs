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
    public class MemberController : ControllerBase
    {
        private MathModelingContext context;
        public MemberController(MathModelingContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetMembers()
        {
            var members = context.Members.ToList();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public IActionResult GetMember(int id)
        {
            var member = context.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                return Ok(member);
            } else
            {
                return BadRequest("Cannot find member.");
            }
        }
    }
}
