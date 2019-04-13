using Newtonsoft.Json;
using System;

namespace PlexSharp.Webhooks.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Server
    {
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
