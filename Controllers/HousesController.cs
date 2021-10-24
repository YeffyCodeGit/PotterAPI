using HarryPotterAPI.Models;
using HarryPotterAPI.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Controllers
{
    /// <summary>
    /// Controls all the endpoints related to getting data on the different hogwarts houses.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class HousesController : ControllerBase
    {
        /// <summary>
        /// Gets all the houses in Hogwarts.
        /// </summary>
        /// <returns>A collection of all the houses.</returns>
        [HttpGet("/houses/all")]
        public async Task<IEnumerable<House>> GetAllHouses() => await JsonUtilities.ReadJsonAsObjectArrayAsync<House>("./Data/houses.json");
    }
}
