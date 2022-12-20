using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CookieStandAspNet.Data;
using CookieStandAspNet.Models;

namespace CookieStandAspNet.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookieStandController : ControllerBase
    {
        private readonly ICookieStand _context;

        public CookieStandController(ICookieStand c)
        {
            _context = c;
        }

        // GET: api/CookieStand
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CookieStand>>> GetCookieStands()
        {
            // You should count the list ...
            var list = await _context.GetCookieStands();
            return Ok(list);
        }

        // GET: api/CookieStand/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CookieStand>> GetCookieStand(int id)
        {
            CookieStand cookieStand = await _context.GetCookieStand(id);
            return cookieStand;
        }

        // PUT: api/CookieStand/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Create(int id, CookieStand cookieStand)
        {
            if (id != cookieStand.Id)
            {
                return BadRequest();
            }

            var updatedCookieStand = await _context.UpdateCookieStand(id, cookieStand);

            return Ok(updatedCookieStand);
        }

        // POST: api/CookieStand
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CookieStand>> UpdateAmenitie(CookieStand cookieStand)
        {
            await _context.Create(cookieStand);

            // Return a 201 Header to browser
            // The body of the request will be us running GetTechnology(id);
            return CreatedAtAction("GetAmenitie", new { id = cookieStand.Id }, cookieStand);
        }

        // DELETE: api/CookieStand/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Delete(id);
            return NoContent();
        }
    }
}
