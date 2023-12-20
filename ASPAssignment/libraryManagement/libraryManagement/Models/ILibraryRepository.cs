namespace libraryManagement.Models
{
    public interface ILibraryRepository
    {
        Library GetBook(int Id);
        IEnumerable<Library> GetAllBooks();
        Library Add(Library book);
        Library Update(Library bookChanges);
        Library Delete(Library book);
    }
}
