using System.Text.Json.Serialization;

namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints.Characters;

public class RegisterCharacterRequest
{
    /// <summary>
    /// The name of the character that is being registered to receive services
    /// </summary>
    [JsonPropertyName("characterName")]
    public required string Name { get; set; }
}