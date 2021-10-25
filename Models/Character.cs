using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    /// <summary>
    /// Represents a character in the Wizarding World.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The full name of the character.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// The actor who played the role of the character in the movies.
        /// </summary>
        [JsonProperty("actor")]
        public string Actor { get; init; }

        /// <summary>
        /// The Hogwarts house of the character.
        /// </summary>
        [JsonProperty("house")]
        public string House { get; init; }
        
        /// <summary>
        /// The gender of the character. 
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; init; }

        /// <summary>
        /// The blood status of the character, Half-Blood, Pure-Blood or Muggle-born.
        /// </summary>
        [JsonProperty("blood_status")]
        public string BloodStatus { get; init; }

        /// <summary>
        /// If the character is a death eater or not
        /// </summary>
        [JsonProperty("is_death_eater")]
        public bool IsDeathEater { get; init; }

        /// <summary>
        /// The patronous of the character, null if it's a corporeal patronous or the wizard cannot conjure a patronous.
        /// </summary>
        [JsonProperty("patronus")]
        public string Patronus { get; init; }

        /// <summary>
        /// All the wands the character has owned.
        /// </summary>
        [JsonProperty("wand")]
        public Wand[] Wands { get; init; }
    }
}
