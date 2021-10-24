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
    /// Controls all the endpoints related to getting data on the different subjects taught at wizarding schools.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class SubjectsController : ControllerBase
    {
        /// <summary>
        /// Gets all the subjects in wizarding schools.
        /// </summary>
        /// <returns>A collection of all the subjects.</returns>
        [HttpGet("/subjects/all")]
        public async Task<IEnumerable<Subject>> GetAllSubjects() => await JsonUtilities.ReadJsonAsObjectArrayAsync<Subject>("./Data/subjects.json");
    }
}