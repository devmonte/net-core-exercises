using _12_LibraryCRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LibraryCRUD.Services
{
    public class SeedDataService : ISeedDataService
    {
        private readonly LibraryContext _libraryContext;

        public SeedDataService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public void SeedData()
        {
            if (_libraryContext.Books.Count() == 0 && _libraryContext.Authors.Count() == 0)
            {

                var sapkowski = new Author { AuthorId = Guid.NewGuid(), BirthYear = new DateTime(175, 10, 13), Name = "Andrzej Sapkowski" };
                var krewElfow = new Book { BookId = Guid.NewGuid(), Price = 50, Title = "Krew Elfów", PublishedYear = new DateTime(2001, 10, 10) };
                var bookAuthor = new BookAuthor { BookAuthorId = Guid.NewGuid(), Author = sapkowski, Book = krewElfow };
                sapkowski.BookAuthors = new List<BookAuthor> { bookAuthor };
                krewElfow.BookAuthors = new List<BookAuthor> { bookAuthor };

                _libraryContext.Authors.Add(sapkowski);
                _libraryContext.Books.Add(krewElfow);
                _libraryContext.SaveChanges();
            }
        }
    }
}
