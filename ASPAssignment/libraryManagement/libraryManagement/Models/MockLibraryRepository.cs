
using System.Runtime.InteropServices;

namespace libraryManagement.Models
{
    public class MockLibraryRepository : ILibraryRepository
    { 
        private readonly AppDbContext _context;

        public MockLibraryRepository(AppDbContext context)
        {
            _context = context;
        }
        public Library Add(Library book)
        {
            _context.Add(book);
            _context.SaveChanges();
            return book;
        }
        public Library Delete(Library book)
        {
            book.IsDeleted = true;
            var bookUpdate = _context.Libraries.Attach(book);
            bookUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return book;
        }

        public IEnumerable<Library> GetAllBooks()
        {
            return _context.Libraries;
        }

        public Library GetBook(int Id)
        {
            return _context.Libraries.Find(Id);
        }

        public Library Update(Library bookChanges)
        {
            var bookUpdate = _context.Libraries.Attach(bookChanges);
            bookUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return bookChanges;
        }
    }
}
