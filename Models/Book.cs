using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    /// <summary>
    /// Represents a published Harry Potter book.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// The name of the book.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// When the book was published.
        /// </summary>
        [JsonProperty("published_at")]
        public string Published { get; init; }

        /// <summary>
        /// How many pages are in the book.
        /// </summary>
        [JsonProperty("page_count")]
        public int Pages { get; init; }
    }
}
