using MifacturaStoreApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MifacturaStoreApi.Services;

public class MifacturasService
{
    private readonly IMongoCollection<Mifactura> _mifacturasCollection;

    public MifacturasService(
        IOptions<MifacturaStoreDatabaseSettings> mifacturaStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            mifacturaStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            mifacturaStoreDatabaseSettings.Value.DatabaseName);

        _mifacturasCollection = mongoDatabase.GetCollection<Mifactura>(
            mifacturaStoreDatabaseSettings.Value.MifacturasCollectionName);
    }

    public async Task<List<Mifactura>> GetAsync() =>
        await _mifacturasCollection.Find(_ => true).ToListAsync();

    public async Task<Mifactura?> GetAsync(string id) =>
        await _mifacturasCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Mifactura newMifactura) =>
        await _mifacturasCollection.InsertOneAsync(newMifactura);

    public async Task UpdateAsync(string id, Mifactura updatedMifactura) =>
        await _mifacturasCollection.ReplaceOneAsync(x => x.Id == id, updatedMifactura);

    public async Task RemoveAsync(string id) =>
        await _mifacturasCollection.DeleteOneAsync(x => x.Id == id);
}