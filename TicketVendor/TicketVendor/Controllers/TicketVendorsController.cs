using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketVendor;
using TicketVendor.Data;

namespace TicketVendor.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketVendorsController : ControllerBase
    {
        private readonly TicketVendorContext _context;

        public TicketVendorsController(TicketVendorContext context)
        {
            _context = context;

        }


        // GET: api/TicketVendors
        [HttpGet]
        public IEnumerable<TicketVendor> GetTickets()
        {
            return _context.Tickets;
        }

        // GET: api/TicketVendors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicketById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ticketVendor = await _context.Tickets.FindAsync(id);

            if (ticketVendor == null)
            {
                return NotFound();
            }

            return Ok(ticketVendor);
        }

        [HttpGet("act/{act}")]
        public IActionResult GetTicketsByAct(String act)
        {
            var entry = _context.Tickets.FirstOrDefault(e => e.Act.ToUpper() == act.ToUpper());
            if (entry == null)
            {
                return NotFound();
            }
            return Ok(entry);
        }

        [HttpGet("venue/{venue}")]
        public IEnumerable<TicketVendor> GetTicketsByVenue(String venue)
        {
              return _context.Tickets.Where(e => e.Venue.ToUpper() == venue.ToUpper());                 
        }

        [HttpGet ("dates")]
        public IEnumerable<TicketVendor> GetDate()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddMonths(3);
            return _context.Tickets.Where(e => e.Date <= endDate);

            

        }

        [HttpGet("available")]
        public IEnumerable<TicketVendor> GetTicketsAvailable()
        {
            return _context.Tickets.Where(e => e.TicketsAvailable > 0);
        }

        
        /*
                // PUT: api/TicketVendors/5
                [HttpPut("{id}")]
                public async Task<IActionResult> PutTicketVendor([FromRoute] int id, [FromBody] TicketVendor ticketVendor)
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    if (id != ticketVendor.TicketID)
                    {
                        return BadRequest();
                    }

                    _context.Entry(ticketVendor).State = EntityState.Modified;

                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!TicketVendorExists(id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                    return NoContent();
                }

                // POST: api/TicketVendors
                [HttpPost]
                public async Task<IActionResult> PostTicketVendor([FromBody] TicketVendor ticketVendor)
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    _context.TicketVendors.Add(ticketVendor);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("GetTicketVendor", new { id = ticketVendor.TicketID }, ticketVendor);
                }

                // DELETE: api/TicketVendors/5
                [HttpDelete("{id}")]
                public async Task<IActionResult> DeleteTicketVendor([FromRoute] int id)
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    var ticketVendor = await _context.TicketVendors.FindAsync(id);
                    if (ticketVendor == null)
                    {
                        return NotFound();
                    }

                    _context.TicketVendors.Remove(ticketVendor);
                    await _context.SaveChangesAsync();

                    return Ok(ticketVendor);
                }
        */
        private bool TicketVendorExists(int id)
        {
            return _context.Tickets.Any(e => e.TicketID == id);
        }

    
    }
    
}