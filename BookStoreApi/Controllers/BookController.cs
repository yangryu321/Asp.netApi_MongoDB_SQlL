using System;
using BookStoreApi.Models;
using BookStoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Core.Operations;
namespace BookStoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(bookRepository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = bookRepository.Get(id);

            if (book == null)
                return NotFound();
            return Ok(book);

        }

        [HttpPost]
        public IActionResult Post(SqlBook book)
        {
            var bookId = bookRepository.Create(book);
            return CreatedAtAction(nameof(Get), new { id = bookId }, book);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, SqlBook updatedBook)
        {
            var book = bookRepository.Get(id);

            if (book == null)
                return NotFound();

            bookRepository.Update(id,updatedBook);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
              var book = bookRepository.Get(id);

            if (book == null)
                return NotFound();

            bookRepository.Delete(id);
            return NoContent();
        }

    }
}