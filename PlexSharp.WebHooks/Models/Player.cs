using Newtonsoft.Json;
using System;

namespace PlexSharp.Webhooks.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Player
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("local")]
        public bool Local { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("public virtualAddress")]
        public string PublicAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        public override string ToString()
        {
            return $"{{ Title = \"{Title}\", Uuid = \"{Uuid}\" }}";
        }
    }
}
