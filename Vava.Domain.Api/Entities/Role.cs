using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class Role
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("displayIcon")]
        public string DisplayIcon { get; set; }

        [JsonPropertyName("assetPath")]
        public string AssetPath { get; set; }
    }
}
