using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HarryPotterAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryPotterAPI.Models;

namespace HarryPotterAPI.Controllers
{
    /// <summary>
    /// Controls all the endpoints related to getting data on the Harry Potter books.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class BooksController : ControllerBase
    {
        /// <summary>
        /// Returns a JSON object containing all the books in the franchise.
        /// </summary> 
        /// <returns>A collection of all the books in the franchise.</returns>
        [HttpGet("books/all")]
        public async Task<IEnumerable<Book>> GetAllBooks() => await JsonUtilities.ReadJsonAsObjectArrayAsync<Book>("./Data/books.json");


        /// <summary>
        /// Returns a JSON object of the requested book.
        /// </summary>
        /// <param name="name">The name of the book.</param>
        /// <returns>The book requested by the user.</returns>
        [HttpGet("/books")]
        public async Task<Book> GetBook(string name)
        {
            List<Book> books = (await GetAllBooks()).ToList();

            return books?.FirstOrDefault(b => b.Name == name);
        }
    }
}
