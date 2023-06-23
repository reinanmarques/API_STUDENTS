using System.Text.Json.Serialization;

namespace Vava.Domain.Api.Entities
{
    public class Root
    {
        [JsonPropertyName("uuid")]
        public string Uuid;

        [JsonPropertyName("displayName")]
        public string DisplayName;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("developerName")]
        public string DeveloperName;

        [JsonPropertyName("characterTags")]
        public object CharacterTags;

        [JsonPropertyName("displayIcon")]
        public string DisplayIcon;

        [JsonPropertyName("displayIconSmall")]
        public string DisplayIconSmall;

        [JsonPropertyName("bustPortrait")]
        public string BustPortrait;

        [JsonPropertyName("fullPortrait")]
        public string FullPortrait;

        [JsonPropertyName("fullPortraitV2")]
        public string FullPortraitV2;

        [JsonPropertyName("killfeedPortrait")]
        public string KillfeedPortrait;

        [JsonPropertyName("background")]
        public string Background;

        [JsonPropertyName("backgroundGradientColors")]
        public List<string> BackgroundGradientColors;

        [JsonPropertyName("assetPath")]
        public string AssetPath;

        [JsonPropertyName("isFullPortraitRightFacing")]
        public bool? IsFullPortraitRightFacing;

        [JsonPropertyName("isPlayableCharacter")]
        public bool? IsPlayableCharacter;

        [JsonPropertyName("isAvailableForTest")]
        public bool? IsAvailableForTest;

        [JsonPropertyName("isBaseContent")]
        public bool? IsBaseContent;

        [JsonPropertyName("role")]
        public Role Role;

        [JsonPropertyName("abilities")]
        public List<Ability> Abilities;

        [JsonPropertyName("voiceLine")]
        public VoiceLine VoiceLine;
    }
}
