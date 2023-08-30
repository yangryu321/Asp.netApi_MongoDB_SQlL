using System;
using BookStoreApi.Models;

namespace BookStoreApi.Services
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly AppDbContext dbContext;

        public SqlBookRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Book Create(Book newBook)
        {
            dbContext.Books.Add(newBook);
            return newBook;
        }

        public int Delete(int id)
        {
            var book = dbContext.Books.Find(id);
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
            return id;
        }

        public IEnumerable<Book> Get()
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(int id, Book UpdatedBook)
        {
            throw new NotImplementedException();
        }
    }

}