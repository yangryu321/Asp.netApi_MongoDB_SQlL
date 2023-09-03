
using BookStoreApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BookStoreApi.Services
{
    public class MongoBookRepository : IBookRepository
    {
        private readonly IMongoCollection<MongoBook> _booksCollection;

        public MongoBookRepository(IOptions<BookStoreDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);

            _booksCollection = mongoDatabase.GetCollection<MongoBook>(
            options.Value.BooksCollectionName);

        }
        public object Create(SqlBook newBook)
        {
          
            var MongoBook = new MongoBook()
            {
                //Id = _booksCollection.max,
                BookName = newBook.BookName,
                Price = newBook.Price,
                Category = newBook.Category,
                Author = newBook.Author


            };
            _booksCollection.InsertOne(MongoBook);
            return MongoBook.Id;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SqlBook> Get()
        {
            throw new NotImplementedException();
        }

        public SqlBook Get(int id)
        {
            throw new NotImplementedException();
        }

        public SqlBook Update(int id, SqlBook UpdatedBook)
        {
            throw new NotImplementedException();
        }
    }

}