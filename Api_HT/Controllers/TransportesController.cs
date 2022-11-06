﻿using System;
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
    public class TransportesController : ControllerBase
    {
        private readonly APIDbContext _context;

        public TransportesController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Transportes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transporte>>> GetTransporte()
        {
            return await _context.Transporte.ToListAsync();
        }

        // GET: api/Transportes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transporte>> GetTransporte(int id)
        {
            var transporte = await _context.Transporte.FindAsync(id);

            if (transporte == null)
            {
                return NotFound();
            }

            return transporte;
        }

        // PUT: api/Transportes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransporte(int id, Transporte transporte)
        {
            if (id != transporte.Id)
            {
                return BadRequest();
            }

            _context.Entry(transporte).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransporteExists(id))
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

        // POST: api/Transportes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Transporte>> PostTransporte(Transporte transporte)
        {
            _context.Transporte.Add(transporte);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransporte", new { id = transporte.Id }, transporte);
        }

        // DELETE: api/Transportes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransporte(int id)
        {
            var transporte = await _context.Transporte.FindAsync(id);
            if (transporte == null)
            {
                return NotFound();
            }

            _context.Transporte.Remove(transporte);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransporteExists(int id)
        {
            return _context.Transporte.Any(e => e.Id == id);
        }
    }
}
