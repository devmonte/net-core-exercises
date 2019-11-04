using _12_LibraryCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_LibraryCRUD.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryContext _libraryContext;

        public LibraryController(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public IActionResult Index() => View();

        public IActionResult Books()
        {
            var books = _libraryContext.Books.ToList();
            return View(books);
        }
    }
}
