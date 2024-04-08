using System.Text.Json.Serialization;
using DeathAndedare.EveOnline.AlertingSystem.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DeathAndedare.EveOnline.AlertingSystem.Services;

public class MongoDatabaseOptions
{
    public const string SECTION_NAME = "Mongo";
    
    [JsonPropertyName("ConnectionString")]
    public required string ConnectionString { get; set; }
}

public class MongoDatabase
{
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database; 
    
    public MongoDatabase(IOptions<MongoDatabaseOptions> options)
    {
        var settings = MongoClientSettings.FromConnectionString(options.Value.ConnectionString);
        _client = new MongoClient(settings);
        _database = _client.GetDatabase("eve-online");
    }

    public IMongoCollection<CharacterEntity> GetCharacterCollection()
    {
        return _database.GetCollection<CharacterEntity>("characters");
    }

    public IMongoCollection<CorporationEntity> GetCorporationCollection()
    {
        return _database.GetCollection<CorporationEntity>("corporations");
    }

    public IMongoCollection<AllianceEntity> GetAllianceCollection()
    {
        return _database.GetCollection<AllianceEntity>("alliances");
    }
}