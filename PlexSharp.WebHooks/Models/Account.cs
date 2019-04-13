using Newtonsoft.Json;
using System;

namespace PlexSharp.Webhooks.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Account
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{{ Title = \"{Title}\", Id = {Id} }}";
        }
    }
}
