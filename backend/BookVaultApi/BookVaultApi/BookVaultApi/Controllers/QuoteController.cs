using BookVaultApi.Data;
using BookVaultApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BookVaultApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class QuotesController : ControllerBase
    {
        private readonly BookDbContext _context;

        public QuotesController(BookDbContext context)
        {
            _context = context;
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? User.FindFirstValue("sub")
                ?? string.Empty;
        }

        [HttpGet]
        public async Task<ActionResult<List<Quote>>> GetQuotes()
        {
            var userId = GetUserId();
            var quotes = await _context.Quotes
                .Where(q => q.UserId == userId)
                .ToListAsync();

            return Ok(quotes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Quote>> GetQuoteById(int id)
        {
            var userId = GetUserId();
            var quote = await _context.Quotes
                .FirstOrDefaultAsync(q => q.Id == id && q.UserId == userId);

            if (quote == null)
            {
                return NotFound();
            }

            return Ok(quote);
        }

        [HttpPost]
        public async Task<ActionResult<Quote>> AddQuote(Quote newQuote)
        {
            newQuote.UserId = GetUserId();

            _context.Quotes.Add(newQuote);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuoteById), new { id = newQuote.Id }, newQuote);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuote(int id, Quote updatedQuote)
        {
            var userId = GetUserId();
            var quote = await _context.Quotes
                .FirstOrDefaultAsync(q => q.Id == id && q.UserId == userId);

            if (quote == null)
            {
                return NotFound();
            }

            quote.Text = updatedQuote.Text;
            quote.Author = updatedQuote.Author;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuote(int id)
        {
            var userId = GetUserId();
            var quote = await _context.Quotes
                .FirstOrDefaultAsync(q => q.Id == id && q.UserId == userId);

            if (quote == null)
            {
                return NotFound();
            }

            _context.Quotes.Remove(quote);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}