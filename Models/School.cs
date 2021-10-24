using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    /// <summary>
    /// Represents a wizarding school.
    /// </summary>
    public class School
    {
        /// <summary>
        /// The name of the wizarding school.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// The location of the school.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; init; }
    }
}
