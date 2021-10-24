using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    /// <summary>
    /// Represents a house in Hogwarts.
    /// </summary>
    public class House
    {
        /// <summary>
        /// The name of the house.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// The mascot animal for the house.
        /// </summary>
        [JsonProperty("animal")]
        public string Mascot { get; init; }

        /// <summary>
        /// The properties that set the house apart.
        /// </summary>
        [JsonProperty("properties")]
        public string[] Properties { get; init; }

        /// <summary>
        /// The house colors.
        /// </summary>
        [JsonProperty("colors")]
        public string[] Colors { get; init; }

        /// <summary>
        /// The founder of the house.
        /// </summary>
        [JsonProperty("founder")]
        public string Founder { get; init; }

        /// <summary>
        /// The treasure of the house's founder.
        /// </summary>
        [JsonProperty("treasure")]
        public string Treasure { get; init; }
    }
}
