using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class MediaList
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("wwise")]
        public string Wwise { get; set; }

        [JsonPropertyName("wave")]
        public string Wave { get; set; }
    }
}
