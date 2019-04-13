using Newtonsoft.Json;
using System;

namespace PlexSharp.Webhooks.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Payload
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event")]
        public EventType Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user")]
        public bool User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner")]
        public bool Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account")]
        public Account Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Server")]
        public Server Server { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Player")]
        public Player Player { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata { get; set; }

        public override string ToString()
        {
            return $"{{ Event = \"{Event}\", User = {User}, Owner = {Owner}, Account = {Account}, Server = {Server}, Player = {Player}, Metadata = {Metadata} }}";
        }
    }
}
