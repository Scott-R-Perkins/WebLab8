using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using Microsoft.AspNetCore.Authorization;

namespace backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArmourController : ControllerBase
    {
        private readonly AuthContext _context;

        public ArmourController(AuthContext context)
        {
            _context = context;
        }

        // GET: api/Armour
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armour>>> GetArmour()
        {
          if (_context.Armour == null)
          {
              return NotFound();
          }
            return await _context.Armour.ToListAsync();
        }

        // GET: api/Armour/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Armour>> GetArmour(int id)
        {
          if (_context.Armour == null)
          {
              return NotFound();
          }
            var armour = await _context.Armour.FindAsync(id);

            if (armour == null)
            {
                return NotFound();
            }

            return armour;
        }

        // PUT: api/Armour/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> PutArmour(int id, Armour armour)
        {
            if (id != armour.armourId)
            {
                return BadRequest();
            }

            _context.Entry(armour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmourExists(id))
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

        // POST: api/Armour
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Armour>> PostArmour(Armour armour)
        {
          if (_context.Armour == null)
          {
              return Problem("Entity set 'AuthContext.Armour'  is null.");
          }
            _context.Armour.Add(armour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArmour", new { id = armour.armourId }, armour);
        }

        // DELETE: api/Armour/5
        [HttpDelete("{id}")]
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> DeleteArmour(int id)
        {
            if (_context.Armour == null)
            {
                return NotFound();
            }
            var armour = await _context.Armour.FindAsync(id);
            if (armour == null)
            {
                return NotFound();
            }

            _context.Armour.Remove(armour);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArmourExists(int id)
        {
            return (_context.Armour?.Any(e => e.armourId == id)).GetValueOrDefault();
        }
    }
}
