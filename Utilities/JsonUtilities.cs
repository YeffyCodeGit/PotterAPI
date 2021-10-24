using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Utilities
{
    /// <summary>
    /// Contains utility functions to simplify working with JSON data.
    /// </summary>
    public static class JsonUtilities
    {
        /// <summary>
        /// Reads a valid JSON file and returns it as an array of objects of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type to represent the JSON data as.</typeparam>
        /// <param name="path">The path of the JSON file.</param>
        /// <returns>A IEnumerable of objects of type <typeparamref name="T"/>.</returns>
        public static Task<IEnumerable<T>> ReadJsonAsObjectArrayAsync<T>(string path)
                => ReadJsonAsObjectAsync<IEnumerable<T>>(path);

        /// <summary>
        /// Reads a valid JSON file and returns it as an object of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type to represent the JSON data as.</typeparam>
        /// <param name="path">The path of the JSON file.</param>
        /// <returns>An object of type <typeparamref name="T"/>.</returns>
        public static async Task<T> ReadJsonAsObjectAsync<T>(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string jsonData = await r.ReadToEndAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
        }
    }
}
