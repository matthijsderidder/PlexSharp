using Newtonsoft.Json;
using PlexSharp.Webhooks.Converters;
using System;

namespace PlexSharp.Webhooks.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ratingKey")]
        public string RatingKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parentRatingKey")]
        public string ParentRatingKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("grandparentRatingKey")]
        public string GrandparentRatingKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("librarySectionID")]
        public int LibrarySectionID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("librarySectionKey")]
        public string LibrarySectionKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("librarySectionTitle")]
        public string LibrarySectionTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("librarySectionType")]
        public LibrarySectionType LibrarySectionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public MediaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("grandparentKey")]
        public string GrandparentKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parentKey")]
        public string ParentKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("grandparentTitle")]
        public string GrandparentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parentTitle")]
        public string ParentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contentRating")]
        public string ContentRating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parentIndex")]
        public int ParentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ratingCount")]
        public int RatingCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("art")]
        public string Art { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parentThumb")]
        public string ParentThumb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("grandparentThumb")]
        public string GrandparentThumb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("grandparentArt")]
        public string GrandparentArt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("grandparentTheme")]
        public string GrandparentTheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("originallyAvailableAt"), JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-dd")]
        public DateTime OriginallyAvailableAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("addedAt"), JsonConverter(typeof(EpochToDateTimeConverter))]
        public DateTime AddedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updatedAt"), JsonConverter(typeof(EpochToDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }

        public override string ToString()
        {
            return $"{{ Title = \"{Title}\", Guid = \"{Guid}\" }}";
        }
    }
}
