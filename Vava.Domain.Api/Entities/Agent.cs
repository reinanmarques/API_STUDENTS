using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class Agent
    {

        public Agent() 
        {
            BackgroundGradientColors = new List<string>();
            Abilities = new List<Ability>();

        }
        [JsonPropertyName("uuid")]
        public string UUID { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("developerName")]
        public string DeveloperName { get; set; }

        [JsonPropertyName("characterTags")]
        public object CharacterTags { get; set; }

        [JsonPropertyName("displayIcon")]
        public string DisplayIcon { get; set; }

        [JsonPropertyName("displayIconSmall")]
        public string DisplayIconSmall { get; set; }

        [JsonPropertyName("bustPortrait")]
        public string BustPortrait { get; set; }

        [JsonPropertyName("fullPortrait")]
        public string FullPortrait { get; set; }

        [JsonPropertyName("fullPortraitV2")]
        public string FullPortraitV2 { get; set; }

        [JsonPropertyName("killfeedPortrait")]
        public string KillfeedPortrait { get; set; }

        [JsonPropertyName("background")]
        public string Background { get; set; }

        [JsonPropertyName("backgroundGradientColors")]
        public List<string> BackgroundGradientColors { get;}

        [JsonPropertyName("assetPath")]
        public string AssetPath { get; set; }

        [JsonPropertyName("isFullPortraitRightFacing")]
        public bool? IsFullPortraitRightFacing { get; set; }

        [JsonPropertyName("isPlayableCharacter")]
        public bool? IsPlayableCharacter { get; set; }

        [JsonPropertyName("isAvailableForTest")]
        public bool? IsAvailableForTest { get; set; }

        [JsonPropertyName("isBaseContent")]
        public bool? IsBaseContent { get; set; }

        [JsonPropertyName("role")]
        public Role Role { get; set; }

        [JsonPropertyName("abilities")]
        public ICollection<Ability> Abilities { get; set; }

        [JsonPropertyName("voiceLine")]
        public VoiceLine VoiceLine { get; set; }

    }
}

