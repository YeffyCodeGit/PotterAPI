using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HarryPotterAPI.Models
{
    /// <summary>
    /// Represents a subject taught at wizarding schools.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// The name of the subject.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// If the subject is a core subject that all students must take, or a subject that is optional.
        /// </summary>
        [JsonProperty("core_subject")]
        public bool IsCoreSubject { get; init; }

        /// <summary>
        /// The description of the subject.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }
    }
}
