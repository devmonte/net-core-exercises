using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LibraryCRUD.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime BirthYear { get; set; }

        public IEnumerable<BookAuthor> BookAuthors { get; set; }
    }
}
