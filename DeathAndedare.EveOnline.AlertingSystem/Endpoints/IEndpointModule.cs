namespace DeathAndedare.EveOnline.AlertingSystem.Endpoints;

public interface IEndpointModule
{
    public string ModuleName { get; }
    public void RegisterEndpoints(WebApplication app);
}