#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalScheduleApi.Models;

namespace PersonalScheduleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalScheduleItemsController : ControllerBase
    {
        private readonly PersonalScheduleContext _context;

        public PersonalScheduleItemsController(PersonalScheduleContext context)
        {
            _context = context;
        }

        // GET: api/PersonalScheduleItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalScheduleItem>>> GetPersonalScheduleItems()
        {
            return await _context.PersonalScheduleItems.ToListAsync();
        }

        // GET: api/PersonalScheduleItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalScheduleItem>> GetPersonalScheduleItem(Guid id)
        {
            var personalScheduleItem = await _context.PersonalScheduleItems.FindAsync(id);

            if (personalScheduleItem == null)
            {
                return NotFound();
            }

            return personalScheduleItem;
        }

        // PUT: api/PersonalScheduleItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalScheduleItem(Guid id, PersonalScheduleItem personalScheduleItem)
        {
            if (id != personalScheduleItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(personalScheduleItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalScheduleItemExists(id))
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

        // POST: api/PersonalScheduleItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonalScheduleItem>> PostPersonalScheduleItem(PersonalScheduleItem personalScheduleItem)
        {
            _context.PersonalScheduleItems.Add(personalScheduleItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPersonalScheduleItem), new { id = personalScheduleItem.Id }, personalScheduleItem);
        }

        // DELETE: api/PersonalScheduleItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonalScheduleItem(Guid id)
        {
            var personalScheduleItem = await _context.PersonalScheduleItems.FindAsync(id);
            if (personalScheduleItem == null)
            {
                return NotFound();
            }

            _context.PersonalScheduleItems.Remove(personalScheduleItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonalScheduleItemExists(Guid id)
        {
            return _context.PersonalScheduleItems.Any(e => e.Id == id);
        }
    }
}
