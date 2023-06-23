using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class Role
    {
        [JsonPropertyName("uuid")]
        public string Uuid;

        [JsonPropertyName("displayName")]
        public string DisplayName;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("displayIcon")]
        public string DisplayIcon;

        [JsonPropertyName("assetPath")]
        public string AssetPath;
    }
}
