using Microsoft.EntityFrameworkCore;
using BookVaultApi.Models;
namespace BookVaultApi.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(

                new Book
                {
                    Id = 1,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    PublicationDate = new DateTime(1988, 1, 1),
                    Quote = "When you want something, all the universe conspires in helping you to achieve it."
                },

    new Book
    {
        Id = 2,
        Title = "1984",
        Author = "George Orwell",
        PublicationDate = new DateTime(1949, 6, 8),
        Quote = "Big Brother is watching you."
    },

    new Book
    {
        Id = 3,
        Title = "To Kill a Mockingbird",
        Author = "Harper Lee",
        PublicationDate = new DateTime(1960, 7, 11),
        Quote = "You never really understand a person until you consider things from his point of view."
    },

    new Book
    {
        Id = 4,
        Title = "The Great Gatsby",
        Author = "F. Scott Fitzgerald",
        PublicationDate = new DateTime(1925, 4, 10),
        Quote = "So we beat on, boats against the current, borne back ceaselessly into the past."
    },

    new Book
    {
        Id = 5,
        Title = "Pride and Prejudice",
        Author = "Jane Austen",
        PublicationDate = new DateTime(1813, 1, 28),
        Quote = "It is a truth universally acknowledged."
    },

    new Book
    {
        Id = 6,
        Title = "The Hobbit",
        Author = "J.R.R. Tolkien",
        PublicationDate = new DateTime(1937, 9, 21),
        Quote = "Not all those who wander are lost."
    },

    new Book
    {
        Id = 7,
        Title = "Harry Potter and the Philosopher's Stone",
        Author = "J.K. Rowling",
        PublicationDate = new DateTime(1997, 6, 26),
        Quote = "It does not do to dwell on dreams and forget to live."
    },

    new Book
    {
        Id = 8,
        Title = "The Book Thief",
        Author = "Markus Zusak",
        PublicationDate = new DateTime(2005, 3, 14),
        Quote = "I am haunted by humans."
    },

    new Book
    {
        Id = 9,
        Title = "The Little Prince",
        Author = "Antoine de Saint-Exupéry",
        PublicationDate = new DateTime(1943, 4, 6),
        Quote = "What is essential is invisible to the eye."
    },

    new Book
    {
        Id = 10,
        Title = "Atomic Habits",
        Author = "James Clear",
        PublicationDate = new DateTime(2018, 10, 16),
        Quote = "Every action you take is a vote for the person you wish to become."
    },
    new Book
    {
        Id = 11,
        Title = "test",
        Author = "James Clear",
        PublicationDate = new DateTime(2018, 10, 16),
        Quote = "Every action you take is a vote for the person you wish to become."
    }
    );
        }

        public DbSet<Book> Books { get; set; }
    }
}