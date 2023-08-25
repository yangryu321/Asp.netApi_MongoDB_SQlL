using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreApi.Models
{
    public class Book
    {
        [Key] // If using Entity Framework for SQL
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incrementing primary key
        public int Id { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? MongoId { get; set; }
        public string BookName { get; set; } = null!;
        public decimal Price { get; set; }
        public string Catagory { get; set; } = null!;
        public string Author { get; set; } = null!;
    }

}