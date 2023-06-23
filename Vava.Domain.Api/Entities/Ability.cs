using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class Ability
    {
        [JsonPropertyName("slot")]
        public string Slot;

        [JsonPropertyName("displayName")]
        public string DisplayName;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("displayIcon")]
        public string DisplayIcon;
    }


}
