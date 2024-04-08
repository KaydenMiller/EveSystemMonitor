using DeathAndedare.EveOnline.AlertingSystem.Services;

namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints.Alerts;

public class AlertEndpoints : IEndpointModule
{
    public string ModuleName { get; } = nameof(AlertEndpoints);
    
    public void RegisterEndpoints(WebApplication app)
    {
        var group = app.MapGroup("alert");

        group.MapPost("/", (CreateAlertRequest request, AlertService alertService) =>
        {  
            // Create an alert based on request
            alertService.ProcessAlert(request);

            return Results.NoContent();
        });
    }
}