using System.Text.Json.Serialization;

namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints.Alliances;

public class RegisterAllianceRequest
{
    /// <summary>
    /// The name of the alliance to be registered
    /// </summary>
    [JsonPropertyName("allianceName")]
    public required string Name { get; set; }
    
    /// <summary>
    /// The number of estimated characters that a given alliance has
    /// </summary>
    [JsonPropertyName("estimatedCharacters")]
    public required int Characters { get; set; }

    /// <summary>
    /// The characters to contact should payment be missed and required
    /// </summary>
    [JsonPropertyName("accountants")]
    public required IEnumerable<string> Accountants { get; set; }
}