using MathModeling21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private MathModelingContext context { get; set; }
        public EventController(MathModelingContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            var events = context.Events.OrderBy(e => e.DateStart).ToList();
            //foreach (Event e in events)
            //{
            //    SetStatus(e);
            //}
            return Ok(events);
        }

        [Route("big")]
        [HttpGet]
        public async Task<IActionResult> GetBigEvents()
        {
            var bigevents = await context.Events.Where(e => e.IsBigEvent).OrderBy(e => e.DateStart).ToListAsync();

            return Ok(bigevents);
        }

        [HttpGet("{id}")]
        public IActionResult GetEvent(int id)
        {
            var thisEvent = context.Events.FirstOrDefault(m => m.Id == id);
            if (thisEvent != null)
            {
                //SetStatus(thisEvent);
                return Ok(thisEvent);
            }
            else return BadRequest("Cannot find event");
        }

        //private void SetStatus(Event e)
        //{
        //    if (DateTime.Now < e.DateStart)
        //    {
        //        e.Happening = false;
        //        e.Ended = false;
        //    }
        //    else if (e.DateStart <= DateTime.Now && DateTime.Now <= e.DateEnd)
        //    {
        //        e.Happening = true;
        //        e.Ended = false;
        //    }
        //    else
        //    {
        //        e.Happening = false;
        //        e.Ended = true;
        //    }
        //} 
    }
}
