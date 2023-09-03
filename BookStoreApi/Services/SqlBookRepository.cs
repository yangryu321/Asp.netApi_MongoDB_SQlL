using System;
using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace BookStoreApi.Services
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly AppDbContext dbContext;

        public SqlBookRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public object Create(SqlBook newBook)
        {
            dbContext.Books.Add(newBook);
            dbContext.SaveChanges();
            return newBook.Id;
        }

        public int Delete(int id)
        {
            var book = dbContext.Books.Find(id);
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
            return id;
        }

        public IEnumerable<SqlBook> Get()
        {
            return dbContext.Books.ToList();
        }

        public SqlBook Get(int id)
        {
            return dbContext.Books.Find(id);
        }

        public SqlBook Update(int id, SqlBook UpdatedBook)
        {
            var existingBook = dbContext.Books.Find(id);

            if (existingBook == null)
            {
                return null;
            }

            existingBook.BookName = UpdatedBook.BookName;
            existingBook.Price = UpdatedBook.Price;
            existingBook.Category = UpdatedBook.Category;
            existingBook.Author = UpdatedBook.Author;
            
            dbContext.SaveChanges();

            return UpdatedBook;
        }
    }

}