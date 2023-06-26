using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class Ability
    {
        [JsonPropertyName("slot")]
        public string Slot { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("displayIcon")]
        public string DisplayIcon { get; set; }
    }


}
