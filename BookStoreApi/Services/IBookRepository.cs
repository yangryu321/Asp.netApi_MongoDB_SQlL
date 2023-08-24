
using BookStoreApi.Models;

namespace BookStoreApi.Services
{
    public interface IBookRepository
    {
        IEnumerable<Book> Get();
        Book Get(int id);
        Book Create(Book newBook);
        Book Update(int id, Book UpdatedBook);
        Book Delete(int id);

    }
}