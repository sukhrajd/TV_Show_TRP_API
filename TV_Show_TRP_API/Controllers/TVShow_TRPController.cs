using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TV_Show_TRP_API.Data;
using TV_Show_TRP_API.Models;

namespace TV_Show_TRP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVShow_TRPController : ControllerBase
    {
        private readonly TV_Show_TRP_APIContext _context;

        public TVShow_TRPController(TV_Show_TRP_APIContext context)
        {
            _context = context;
        }

        // GET: api/TVShow_TRP
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TVShow_TRP>>> GetTVShow_TRP()
        {
            return await _context.TVShow_TRP.ToListAsync();
        }

        // GET: api/TVShow_TRP/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TVShow_TRP>> GetTVShow_TRP(int id)
        {
            var tVShow_TRP = await _context.TVShow_TRP.FindAsync(id);

            if (tVShow_TRP == null)
            {
                return NotFound();
            }

            return tVShow_TRP;
        }

        // PUT: api/TVShow_TRP/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTVShow_TRP(int id, TVShow_TRP tVShow_TRP)
        {
            if (id != tVShow_TRP.Id)
            {
                return BadRequest();
            }

            _context.Entry(tVShow_TRP).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TVShow_TRPExists(id))
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

        // POST: api/TVShow_TRP
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TVShow_TRP>> PostTVShow_TRP(TVShow_TRP tVShow_TRP)
        {
            _context.TVShow_TRP.Add(tVShow_TRP);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTVShow_TRP", new { id = tVShow_TRP.Id }, tVShow_TRP);
        }

        // DELETE: api/TVShow_TRP/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TVShow_TRP>> DeleteTVShow_TRP(int id)
        {
            var tVShow_TRP = await _context.TVShow_TRP.FindAsync(id);
            if (tVShow_TRP == null)
            {
                return NotFound();
            }

            _context.TVShow_TRP.Remove(tVShow_TRP);
            await _context.SaveChangesAsync();

            return tVShow_TRP;
        }

        private bool TVShow_TRPExists(int id)
        {
            return _context.TVShow_TRP.Any(e => e.Id == id);
        }
    }
}
