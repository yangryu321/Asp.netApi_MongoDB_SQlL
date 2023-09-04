using System;
using BookStoreApi.Models;

namespace BookStoreApi.Services
{
    public interface IBookRepository
    {
        IEnumerable<object> Get();
        object Get(int id);
        object Create(SqlBook newBook);
        SqlBook Update(int id, SqlBook UpdatedBook);
        int Delete(int id);

    }
}