using MongoDB.Bson.Serialization.Attributes;

namespace DeathAndedare.EveOnline.AlertingSystem.Models;

public class AllianceEntity
{
    [BsonElement("name")]
    public required string Name { get; set; }
    [BsonElement("accountants")]
    public required IEnumerable<string> Accountants { get; set; }
    [BsonElement("lastPaymentReceived")]
    public required DateTime LastPaymentReceived { get; set; }
    [BsonElement("corporations")]
    public required IEnumerable<CorporationEntity> Corporations { get; set; }
    [BsonElement("requiredPaymentAmount")]
    public required decimal RequiredPaymentAmount { get; set; }
}