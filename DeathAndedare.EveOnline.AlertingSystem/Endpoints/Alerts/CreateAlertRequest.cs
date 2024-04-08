using System.Text.Json.Serialization;

namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints.Alerts;

public class CreateAlertRequest
{
    /// <summary>
    /// The system the alert is for
    /// </summary>
    [JsonPropertyName("system")]
    public required string System { get; set; }
    
    /// <summary>
    /// The status of the alert (clear, active, ...)
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    
    /// <summary>
    /// The count of hostiles if known for a given alert
    /// </summary>
    [JsonPropertyName("countOfHostiles")]
    public required int? CountOfHostiles { get; set; }
    
    /// <summary>
    /// Public Alerts go to anyone who is listening for an alert in a given system
    /// </summary>
    [JsonPropertyName("isPublicAlert")]
    public required bool IsPublicAlert { get; set; }
}