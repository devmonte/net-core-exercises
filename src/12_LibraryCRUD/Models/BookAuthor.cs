using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LibraryCRUD.Models
{
    public class BookAuthor
    {
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }

        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
