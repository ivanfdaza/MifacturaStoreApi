namespace MifacturaStoreApi.Models;

public class MifacturaStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string MifacturasCollectionName { get; set; } = null!;
}