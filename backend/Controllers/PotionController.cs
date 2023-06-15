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
    public class PotionController : ControllerBase
    {
        private readonly AuthContext _db;

        public PotionController(AuthContext db)
        {
            _db = db;
        }

        // GET: api/Potion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Potion>>> GetPotion()
        {
          if (_db.Potion == null)
          {
              return NotFound();
          }
            return await _db.Potion.ToListAsync();
        }

        // GET: api/Potion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Potion>> GetPotion(int id)
        {
          if (_db.Potion == null)
          {
              return NotFound();
          }
            var potion = await _db.Potion.FindAsync(id);

            if (potion == null)
            {
                return NotFound();
            }

            return potion;
        }

        // PUT: api/Potion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> PutPotion(int id, Potion potion)
        {
            if (id != potion.potionId)
            {
                return BadRequest();
            }

            _db.Entry(potion).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PotionExists(id))
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

        // POST: api/Potion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Potion>> PostPotion(Potion potion)
        {
          if (_db.Potion == null)
          {
              return Problem("Entity set 'AuthContext.Potion'  is null.");
          }
            _db.Potion.Add(potion);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetPotion", new { id = potion.potionId }, potion);
        }

        // DELETE: api/Potion/5
        [HttpDelete("{id}")]
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> DeletePotion(int id)
        {
            if (_db.Potion == null)
            {
                return NotFound();
            }
            var potion = await _db.Potion.FindAsync(id);
            if (potion == null)
            {
                return NotFound();
            }

            _db.Potion.Remove(potion);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool PotionExists(int id)
        {
            return (_db.Potion?.Any(e => e.potionId == id)).GetValueOrDefault();
        }
    }
}
