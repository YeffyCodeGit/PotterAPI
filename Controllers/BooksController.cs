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


        // [HttpGet("/books")]
        // public Book GetBook() => throw new NotImplementedException("TODO: Implement /book endpoint to get a specific book");
    }
}
