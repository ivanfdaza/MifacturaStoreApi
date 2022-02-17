using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MifacturaStoreApi.Models;

public class Producto
{

    [BsonElement("Nombre")]
    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int Cantidad { get; set; }
}