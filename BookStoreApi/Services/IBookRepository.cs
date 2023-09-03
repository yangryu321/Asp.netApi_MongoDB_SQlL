using System;
using BookStoreApi.Models;

namespace BookStoreApi.Services
{
    public interface IBookRepository
    {
        IEnumerable<SqlBook> Get();
        SqlBook Get(int id);
        object Create(SqlBook newBook);
        SqlBook Update(int id, SqlBook UpdatedBook);
        int Delete(int id);

    }
}