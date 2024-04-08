using MongoDB.Bson.Serialization.Attributes;

namespace DeathAndedare.EveOnline.AlertingSystem.Models;

public class CharacterEntity
{
    [BsonElement("name")]
    public required string Name { get; set; }
    [BsonElement("lastPaymentReceived")]
    public required DateTime? LastPaymentReceived { get; set; }
    
    [BsonElement("associatedCorporation")]
    public CorporationEntity? AssociatedCorporation { get; set; }
}