using EventHalls.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Repositories;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventHalls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventsService _eventsService;
        public EventController(IEventsService data)
        {
            _eventsService = data;
        }
        // GET: api/<EventController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_eventsService.GetEvents());
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            //var eve = _eventsService.GetById(id);
            //if (eve==null) 
            //    return NotFound();
            //return Ok(eve);
            return _eventsService.GetById(id);
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody]Event e)
        {
            _eventsService.AddEvents(e);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public ActionResult<Event> Put( int id, [FromBody] Event event1)
        {
            
            {
                return Ok(_eventsService.UpdateEvents(id, event1));
            }
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public ActionResult<Event> Delete(int id)
        {
            _eventsService.DeleteEvents(id);
            return Ok();
        }
    }
}
