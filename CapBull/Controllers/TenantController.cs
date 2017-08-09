using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CapBull.Models;

namespace CapBull.Controllers
{
    [Produces("application/json")]
    [Route("api/Tenant")]
    public class TenantController : Controller
    {
        private readonly CapBullContext _context;

        public TenantController(CapBullContext context)
        {
            _context = context;
        }

        // GET: api/Tenant
        [HttpGet]
        public IEnumerable<TENANT> GetTENANT()
        {
            return _context.TENANT;
        }

        // GET: api/Tenant/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTENANT([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tENANT = await _context.TENANT.SingleOrDefaultAsync(m => m.TenantID == id);

            if (tENANT == null)
            {
                return NotFound();
            }

            return Ok(tENANT);
        }

        // PUT: api/Tenant/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTENANT([FromRoute] int id, [FromBody] TENANT tENANT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tENANT.TenantID)
            {
                return BadRequest();
            }

            _context.Entry(tENANT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TENANTExists(id))
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

        // POST: api/Tenant
        [HttpPost]
        public async Task<IActionResult> PostTENANT([FromBody] TENANT tENANT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TENANT.Add(tENANT);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTENANT", new { id = tENANT.TenantID }, tENANT);
        }

        // DELETE: api/Tenant/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTENANT([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tENANT = await _context.TENANT.SingleOrDefaultAsync(m => m.TenantID == id);
            if (tENANT == null)
            {
                return NotFound();
            }

            _context.TENANT.Remove(tENANT);
            await _context.SaveChangesAsync();

            return Ok(tENANT);
        }

        private bool TENANTExists(int id)
        {
            return _context.TENANT.Any(e => e.TenantID == id);
        }
    }
}