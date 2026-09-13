using BookVaultApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookVaultApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
namespace BookVaultApi.Controllers
{
    [Route("api/[controller]")]


    [ApiController]



    public class BooksController : ControllerBase
    {




        //private static List<Book> books = new List<Book>
        //    {
        //        new Book
        //        {

        //            Id = 1,
        //            Title="The Alchemist",
        //            Author="Paulo Coelho",
        //            PublicationDate= new DateTime(1988,1,1),
        //            Quote = "When you want something, all the universe conspires in helping you to achieve it."
        //        },
        //         new Book
        //        {

        //            Id = 2,
        //            Title="1984",
        //            Author="George Orwell",
        //            PublicationDate= new DateTime(1949,6,8),
        //            Quote = "When you want something, all the universe conspires in helping you to achieve it."
        //        },

        //    };

        private readonly BookDbContext _context;

        public BooksController(BookDbContext context)

        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Book>>> GetBooks()
        {

            //var books = await _context.Books.ToListAsync();

            return Ok(await _context.Books.ToListAsync());
        }

        [HttpGet("{id}")]

            public async Task<ActionResult<Book>> GetBookById(int Id)
            {


            var book = await _context.Books.FindAsync(Id);

            if (book == null)
              {
                   return NotFound();

               }

               return Ok(book);
           }

        [HttpPost]

        public async Task<ActionResult<Book>> AddBook(Book newBook)
        {


            if (newBook == null)
            {

                return BadRequest();

            }

            _context.Books.Add(newBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBookById), new {id = newBook.Id} , newBook);



        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateBookDetail(int id, Book updatedBook)
        {

            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {

                return NotFound();
            }

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.PublicationDate = updatedBook.PublicationDate;
            book.Quote = updatedBook.Quote;

            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteBook(int id)
        {

            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);

            _context.SaveChanges();

            return NoContent();
        }


    }
}

