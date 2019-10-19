using System;
using System.Text.Json.Serialization;

namespace EVEStandard.Models.SSO
{
    public class CharacterDetails
    {
        [JsonPropertyName("CharacterID")]
        public int CharacterId { get; set; }
        [JsonPropertyName("CharacterName")]
        public string CharacterName { get; set; }
        [JsonPropertyName("ExpiresOn")]
        public DateTime ExpiresOn { get; set; }
        [JsonPropertyName("Scopes")]
        public string Scopes { get; set; }
        [JsonPropertyName("TokenType")]
        public string TokenType { get; set; }
        [JsonPropertyName("CharacterOwnerHash")]
        public string CharacterOwnerHash { get; set; }
    }
}
