using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    public class Wand
    {
        [JsonProperty("wood")]
        public string Wood { get; init; }

        [JsonProperty("core")]
        public string Core { get; init; }

        [JsonProperty("length")]
        public float? Length { get; init; }
    }
}
