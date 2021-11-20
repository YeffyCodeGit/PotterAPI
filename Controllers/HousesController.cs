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

        
        /// <summary>
        /// Returns a JSON object of the requested house.
        /// </summary>
        /// <param name="name">The name of the house.</param>
        /// <returns>The house requested by the user.</returns>
        [HttpGet("/houses")]
        public async Task<House> GetHouse(string name)
        {
            IEnumerable<House> houses = await GetAllHouses();

            return houses?.FirstOrDefault(h => h.Name == name);
        }
    }
}
