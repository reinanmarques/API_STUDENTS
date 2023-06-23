using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class MediaList
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("wwise")]
        public string Wwise;

        [JsonPropertyName("wave")]
        public string Wave;
    }
}
