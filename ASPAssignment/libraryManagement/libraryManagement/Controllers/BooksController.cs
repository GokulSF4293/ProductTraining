using Azure.Core;
using libraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace libraryManagement.Controllers
{
    public class BooksController : Controller

    {
        private ILibraryRepository _bookRepository;
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger, ILibraryRepository libraryRepository)
        {
            _bookRepository = libraryRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Model = _bookRepository.GetAllBooks();
            return View(Model);
        }
        [Route("{controller}/new-{action}")]
        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        [Route("{controller}/new-{action}")]
        [HttpPost]
        public IActionResult Add(Library book)
        {
            if(ModelState.IsValid && book.CategoryName != Department.None)
            {
                Library newBook = _bookRepository.Add(book);
                return RedirectToAction("Index");
            }
            return View();
        }
        [Route("{controller}/{id}-{action}")]
        public IActionResult View(int id)
        {
            var book = _bookRepository.GetBook(id);
            if(book == null || book.IsDeleted == true)
            {
                return RedirectToAction("ErrorPage");
            }
            return View(book);
        }
        [Route("{controller}/edit/{id}-{action}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookRepository.GetBook(id);
            if (book == null || book.IsDeleted == true)
            {
                return RedirectToAction("ErrorPage");
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Library modifiedBook)
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
                return RedirectToAction("View", new { id = book.BookId });
            }
            return View("Edit", modifiedBook);
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

        public IActionResult ErrorPage() 
        {
            return View("ErrorPage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
