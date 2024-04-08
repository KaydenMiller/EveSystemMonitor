namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints.Characters;

public class CharacterEndpoints : IEndpointModule
{
    public string ModuleName { get; } = nameof(CharacterEndpoints);
    
    public void RegisterEndpoints(WebApplication app)
    {
        var group = app.MapGroup("character");

        // character/register
        group.MapPost("register", (RegisterCharacterRequest request) =>
        {
            
        });
        
        // character/corporation/{id}/join
        group.MapPost("corporation/{id}/join", (string id) =>
        {

        });
    }
}