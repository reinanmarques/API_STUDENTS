using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class VoiceLine
    {

        public VoiceLine()
        {
            MediaList = new List<MediaList>();

        }
        [JsonPropertyName("minDuration")]
        public double? MinDuration { get; set; }

        [JsonPropertyName("maxDuration")]
        public double? MaxDuration { get; set; }

        [JsonPropertyName("mediaList")]
        public List<MediaList> MediaList { get; set; }
    }
}
