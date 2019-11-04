using _12_LibraryCRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LibraryCRUD.Models
{
    public class BorrowBookViewModel
    {
        public List<Book> Books { get; set; }
        public List<Client> Clients { get; set; }
        public Guid ClientId { get; set; }
        public Guid BookId { get; set; }

    }
}
