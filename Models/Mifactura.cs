using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace MifacturaStoreApi.Models;

public class Mifactura
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Tienda")]
    [JsonPropertyName("Tienda")]
    public string Tienda { get; set; } = null!;

    public decimal Valor { get; set; }

    public DateTime Fecha { get; set; } = DateTime.Now;

    [BsonElement("Cliente")]
    public Cliente ClienteFactura { get; set; } = null!;

    public ICollection<Producto> Productos { get; set; } = null!;
}