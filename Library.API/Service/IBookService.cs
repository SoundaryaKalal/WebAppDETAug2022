using Library.API.Models;

namespace Library.API.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Add(Book newBook);

        Book GetById(Guid id);

        void Remove(Guid id);
    }
}


