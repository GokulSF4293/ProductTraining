using Azure.Core;
using libraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace libraryManagement.Controllers
{
    public class HomeController : Controller

    {
        private ILibraryRepository _bookRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ILibraryRepository libraryRepository)
        {
            _bookRepository = libraryRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Model = _bookRepository.GetAllBooks();
            return View(Model);
        }
        [HttpGet]
        public ViewResult NewBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewBook(Library book)
        {
            if(ModelState.IsValid) 
            {
                Library newBook = _bookRepository.Add(book);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult BookDetails(int id)
        {
            var book = _bookRepository.GetBook(id);
            return View(book);
        }
        [HttpGet]
        public ViewResult EditBookDetails(int id)
        {
            var book = _bookRepository.GetBook(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult EditBookDetails(Library modifiedBook)
        {
            if (ModelState.IsValid)
            {
                Library book = _bookRepository.GetBook(modifiedBook.BookId);
                book.BookId = modifiedBook.BookId;
                book.BookName = modifiedBook.BookName;
                book.AuthorName = modifiedBook.AuthorName;
                book.PublishedYear = modifiedBook.PublishedYear;
                book.Price = modifiedBook.Price;
                book.UpdatedOn = modifiedBook.UpdatedOn;
                book.CategoryName = modifiedBook.CategoryName;

                _bookRepository.Update(book);
                return RedirectToAction("BookDetails", new { id = book.BookId });
            }
            return View("EditBookDetails", modifiedBook);
            //// return RedirectToAction("EditBookDetails");
        }

        public IActionResult DeleteBook(int id) 
        {
            Library book = _bookRepository.GetBook(id);
            if(book == null || book.IsDeleted == true) 
            {
                return RedirectToAction("Index");
            }
            else if(book.IsDeleted == false) 
            {
                _bookRepository.Delete(book);
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
