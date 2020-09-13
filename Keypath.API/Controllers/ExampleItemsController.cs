using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Keypath.API.DAL;
using Keypath.API.Models;
using Microsoft.AspNetCore.Cors;

namespace Keypath.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("Policy01")]
    public class ExampleItemsController : ControllerBase
    {
        private readonly KeypathContext _context;

        public ExampleItemsController(KeypathContext context)
        {
            _context = context;
        }

        // GET: api/ExampleItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExampleItem>>> GetExampleItems([FromQuery] string wordContains=null)
        {
            string filter = String.IsNullOrWhiteSpace(wordContains) ? String.Empty : wordContains;
            return await _context.ExampleItems
                            .OrderBy(ei => ei.Id)
                            .Where(ei => ei.Word.Contains(filter))
                            .ToListAsync();
        }


        // GET: api/ExampleItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExampleItem>> GetExampleItem(long id)
        {
            var exampleItem = await _context.ExampleItems.FindAsync(id);

            if (exampleItem == null)
            {
                return NotFound();
            }

            return exampleItem;
        }

        // PUT: api/ExampleItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExampleItem(long id, ExampleItem exampleItem)
        {
            if (id != exampleItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(exampleItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExampleItemExists(id))
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

        // POST: api/ExampleItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("/api/[controller]")]
        [Route("/api/[controller]/json")]
        public async Task<ActionResult<ExampleItem>> PostExampleItemJSON(ExampleItem exampleItem)
        {
            return await PostNewRow(exampleItem);
        }

        [HttpPost]
        [Route("/api/[controller]/query")]
        public async Task<ActionResult<ExampleItem>> PostExampleIteQUERY([FromQuery] ExampleItem exampleItem)
        {
            return await PostNewRow(exampleItem);
        }

        [HttpPost]
        [Route("/api/[controller]/form")]
        public async Task<ActionResult<ExampleItem>> PostExampleItemFORM([FromForm] ExampleItem exampleItem)
        {
            return await PostNewRow(exampleItem);
        }


        private async Task<CreatedAtActionResult> PostNewRow(ExampleItem exampleItem)
        {
            _context.ExampleItems.Add(exampleItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExampleItem), new { id = exampleItem.Id }, exampleItem);
        }

        // DELETE: api/ExampleItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExampleItem>> DeleteExampleItem(long id)
        {
            var exampleItem = await _context.ExampleItems.FindAsync(id);
            if (exampleItem == null)
            {
                return NotFound();
            }

            _context.ExampleItems.Remove(exampleItem);
            await _context.SaveChangesAsync();

            return exampleItem;
        }

        private bool ExampleItemExists(long id)
        {
            return _context.ExampleItems.Any(e => e.Id == id);
        }
    }
}
