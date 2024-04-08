using MongoDB.Bson.Serialization.Attributes;

namespace DeathAndedare.EveOnline.AlertingSystem.Models;

public class CorporationEntity
{
    [BsonElement("name")]
    public required string Name { get; set; }
    [BsonElement("accountants")]
    public required IEnumerable<string> Accountants { get; set; }
    [BsonElement("lastPaymentReceived")]
    public required DateTime LastPaymentReceived { get; set; }
    [BsonElement("characters")]
    public required IEnumerable<CharacterEntity> Characters { get; set; }
    
    [BsonElement("associatedAlliance")]
    public AllianceEntity? AssociatedAlliance { get; set; }
}