using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MifacturaStoreApi.Models;

public class Cliente
{

    [BsonElement("Nombre")]
    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;
}