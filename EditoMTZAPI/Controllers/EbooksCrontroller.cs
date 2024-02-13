using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EditoMTZAPI.DatabaseContext;
using EditoMTZAPI.Models;

namespace EditoMTZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EbooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ebooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ebook>>> GetEbooks()
        {
            return await _context.Ebooks.ToListAsync();
        }

        // GET: api/EbooksCrontroller/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ebook>> GetEbook(Guid id)
        {
            var ebook = await _context.Ebooks.FindAsync(id);

            if (ebook == null)
            {
                return NotFound();
            }

            return ebook;
        }

        // PUT: api/EbooksCrontroller/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // Bind here is to ensure attributes are or not in request
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEbook([Bind(nameof(Ebook.EbookID), nameof(Ebook.EbookName))] Guid id,
            Ebook ebook)
        {
            if (id != ebook.EbookID)
            {
                return BadRequest();
            }

            var existingEbook = await _context.Ebooks.FindAsync(id);
            if (existingEbook == null)
            {
                return NotFound();
            }

            // _context.Entry(ebook).State = EntityState.Modified;// it is very dangerous to update all entity state, we should perform an update only in specific data

            // here we perform the updates only in specific entriy
            existingEbook.EbookName = ebook.EbookName;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EbookExists(id))
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

        // POST: api/EbooksCrontroller
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ebook>> PostEbook(
            [Bind(nameof(Ebook.EbookID), nameof(Ebook.EbookName))] Ebook ebook)
        {
            _context.Ebooks.Add(ebook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEbook", new { id = ebook.EbookID }, ebook);
        }

        // DELETE: api/EbooksCrontroller/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEbook(Guid id)
        {
            var ebook = await _context.Ebooks.FindAsync(id);
            if (ebook == null)
            {
                return NotFound();
            }

            _context.Ebooks.Remove(ebook);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EbookExists(Guid id)
        {
            return _context.Ebooks.Any(e => e.EbookID == id);
        }
    }
}