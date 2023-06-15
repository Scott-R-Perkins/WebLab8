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
    public class WeaponController : ControllerBase
    {
        private readonly AuthContext _db;

        public WeaponController(AuthContext db)
        {
            _db = db;
        }

        // GET: api/Weapon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weapon>>> GetWeapon()
        {
          if (_db.Weapon == null)
          {
              return NotFound();
          }
            return await _db.Weapon.ToListAsync();
        }

        // GET: api/Weapon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weapon>> GetWeapon(int id)
        {
          if (_db.Weapon == null)
          {
              return NotFound();
          }
            var weapon = await _db.Weapon.FindAsync(id);

            if (weapon == null)
            {
                return NotFound();
            }

            return weapon;
        }

        // PUT: api/Weapon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> PutWeapon(int id, Weapon weapon)
        {
            if (id != weapon.weaponId)
            {
                return BadRequest();
            }

            _db.Entry(weapon).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeaponExists(id))
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

        // POST: api/Weapon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Weapon>> PostWeapon(Weapon weapon)
        {
          if (_db.Weapon == null)
          {
              return Problem("Entity set 'AuthContext.Weapon'  is null.");
          }
            _db.Weapon.Add(weapon);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetWeapon", new { id = weapon.weaponId }, weapon);
        }

        // DELETE: api/Weapon/5
        [HttpDelete("{id}")]
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> DeleteWeapon(int id)
        {
            if (_db == null || _db.Weapon == null)
            {
                return NotFound();
            }
            var weapon = await _db.Weapon.FindAsync(id);
            if (weapon == null)
            {
                return NotFound();
            }

            _db.Weapon.Remove(weapon);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool WeaponExists(int id)
        {
            return (_db.Weapon?.Any(e => e.weaponId == id)).GetValueOrDefault();
        }
    }
}
