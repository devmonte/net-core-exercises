using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _12_LibraryCRUD.Models;
using _12_LibraryCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace _12_LibraryCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LibraryContext _libraryContext;

        public HomeController(ILogger<HomeController> logger, LibraryContext libraryContext)
        {
            _logger = logger;
            _libraryContext = libraryContext;
        }

        public IActionResult Index()
        {
            var borrowBookModel = new BorrowBookViewModel
            {
                Books = _libraryContext.Books.ToList(),
                Clients = _libraryContext.Clients.ToList()
            };
            return View(borrowBookModel);
        }

        [HttpPost]
        public IActionResult Borrow(BorrowBookViewModel model)
        {
            var client = _libraryContext.Clients.Include(c => c.Books).First(c => c.ClientId == model.ClientId);
            var book = _libraryContext.Books.Include(b => b.BookAuthors).First(b => b.BookId == model.BookId);

            client.Books.ToList().Add(book);
            _libraryContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
