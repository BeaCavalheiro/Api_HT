using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_HT.Data;
using Api_HT.Model;

namespace Api_HT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospedagemsController : ControllerBase
    {
        private readonly APIDbContext _context;

        public HospedagemsController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Hospedagems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hospedagem>>> GetHospedagem()
        {
            return await _context.Hospedagem.ToListAsync();
        }

        // GET: api/Hospedagems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hospedagem>> GetHospedagem(int id)
        {
            var hospedagem = await _context.Hospedagem.FindAsync(id);

            if (hospedagem == null)
            {
                return NotFound();
            }

            return hospedagem;
        }

        // PUT: api/Hospedagems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospedagem(int id, Hospedagem hospedagem)
        {
            if (id != hospedagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(hospedagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HospedagemExists(id))
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

        // POST: api/Hospedagems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hospedagem>> PostHospedagem(Hospedagem hospedagem)
        {
            _context.Hospedagem.Add(hospedagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHospedagem", new { id = hospedagem.Id }, hospedagem);
        }

        // DELETE: api/Hospedagems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospedagem(int id)
        {
            var hospedagem = await _context.Hospedagem.FindAsync(id);
            if (hospedagem == null)
            {
                return NotFound();
            }

            _context.Hospedagem.Remove(hospedagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HospedagemExists(int id)
        {
            return _context.Hospedagem.Any(e => e.Id == id);
        }
    }
}
