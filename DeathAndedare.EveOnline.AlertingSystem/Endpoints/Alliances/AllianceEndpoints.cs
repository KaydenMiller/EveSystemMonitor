namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints.Alliances;

public class AllianceEndpoints : IEndpointModule
{
    public string ModuleName { get; } = nameof(AllianceEndpoints);
    
    public void RegisterEndpoints(WebApplication app)
    {
        var group = app.MapGroup("alliance");

        group.MapPost("register", (RegisterAllianceRequest request) =>
        {
            
        });
    }
}