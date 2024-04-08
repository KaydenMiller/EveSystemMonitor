namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints.Corporations;

public class CorporationEndpoints : IEndpointModule
{
    public string ModuleName { get; } = nameof(CorporationEndpoints);
    
    public void RegisterEndpoints(WebApplication app)
    {
        var group = app.MapGroup("corporation");

        // corporation/register
        group.MapPost("register", (RegisterCorporationRequest request) =>
        {
            
        });
        
        // corporation/alliance/{id}/join
    }
}