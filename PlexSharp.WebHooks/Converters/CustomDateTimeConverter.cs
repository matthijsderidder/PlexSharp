using Newtonsoft.Json.Converters;

namespace PlexSharp.Webhooks.Converters
{
    class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format = "yyyy-MM-dd")
        {
            DateTimeFormat = format;
        }
    }
}
