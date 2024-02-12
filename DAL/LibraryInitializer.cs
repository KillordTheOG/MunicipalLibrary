using MunicipalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MunicipalLibrary.DAL
{
    public class LibraryInitializer : DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var random = new Random();

            var books = new List<Book>
            {
                new Book
                {
                    Title = "The Catcher in the Rye", Description = "Classic novel by J.D. Salinger",
                    Author = "J.D. Salinger"
                },
                new Book
                {
                    Title = "To Kill a Mockingbird", Description = "Harper Lee's masterpiece", Author = "Harper Lee"
                },
                new Book { Title = "1984", Description = "Dystopian novel by George Orwell", Author = "George Orwell" },
                new Book
                {
                    Title = "The Great Gatsby", Description = "F. Scott Fitzgerald's iconic work",
                    Author = "F. Scott Fitzgerald"
                },
                new Book
                {
                    Title = "Pride and Prejudice", Description = "Jane Austen's classic", Author = "Jane Austen"
                },
                new Book
                {
                    Title = "One Hundred Years of Solitude", Description = "Magical realism by Gabriel Garcia Marquez",
                    Author = "Gabriel Garcia Marquez"
                },
                new Book
                {
                    Title = "The Hobbit", Description = "Fantasy novel by J.R.R. Tolkien", Author = "J.R.R. Tolkien"
                },
                new Book
                {
                    Title = "The Lord of the Rings", Description = "Epic fantasy trilogy by J.R.R. Tolkien",
                    Author = "J.R.R. Tolkien"
                },
                new Book
                {
                    Title = "Harry Potter and the Philosopher's Stone",
                    Description = "First book in the Harry Potter series", Author = "J.K. Rowling"
                },
                new Book
                {
                    Title = "The Hunger Games", Description = "Dystopian novel by Suzanne Collins",
                    Author = "Suzanne Collins"
                }
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var members = new List<Member>
            {
                new Member { Name = "John Doe", Address = "123 Main St" },
                new Member { Name = "Jane Smith", Address = "456 Oak Ave" },
                new Member { Name = "Bob Johnson", Address = "789 Pine Rd" },
                new Member { Name = "Alice Williams", Address = "101 Cedar Ln" },
                new Member { Name = "Charlie Brown", Address = "202 Maple Blvd" },
                new Member { Name = "Eva Green", Address = "303 Birch Dr" },
                new Member { Name = "David Taylor", Address = "404 Spruce Ct" },
                new Member { Name = "Grace Turner", Address = "505 Elm Pl" },
                new Member { Name = "Frank Miller", Address = "606 Walnut Cir" },
                new Member { Name = "Olivia White", Address = "707 Ash Lane" }
            };

            members.ForEach(m =>
            {
                // Randomly select 3 books for each member
                var randomBooks = books.OrderBy(x => random.Next()).Take(3).ToList();
                m.Books = randomBooks;
                context.Members.Add(m);
            });

            context.SaveChanges();
        }
    }
}