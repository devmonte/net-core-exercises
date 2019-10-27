using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LibraryCRUD.Data
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        
        public IEnumerable<Book> Books { get; set; }
    }
}
