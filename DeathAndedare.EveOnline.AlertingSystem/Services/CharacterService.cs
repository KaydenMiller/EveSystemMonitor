using DeathAndedare.EveOnline.AlertingSystem.Endpoints.Characters;
using DeathAndedare.EveOnline.AlertingSystem.Models;

namespace DeathAndedare.EveOnline.AlertingSystem.Services;

public class CharacterService
{
    private readonly MongoDatabase _database;

    public CharacterService(MongoDatabase database)
    {
        _database = database;
    }
    
    public void RegisterCharacter(RegisterCharacterRequest request)
    {
        var characterEntity = new CharacterEntity()
        {
            Name = request.Name,
            LastPaymentReceived = null,
            AssociatedCorporation = null
        };
        
        _database.GetCharacterCollection();
    }
}