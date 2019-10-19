using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LibraryCRUD.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime PublishedYear { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public IEnumerable<BookAuthor> BookAuthors { get; set; }
    }
}
