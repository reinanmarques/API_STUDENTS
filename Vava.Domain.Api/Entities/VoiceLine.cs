using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class VoiceLine
    {
        [JsonPropertyName("minDuration")]
        public double? MinDuration;

        [JsonPropertyName("maxDuration")]
        public double? MaxDuration;

        [JsonPropertyName("mediaList")]
        public List<MediaList> MediaList;
    }
}
