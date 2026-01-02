using MachineApi.Models;
using MongoDB.Driver;

namespace MachineApi.Data  
{
    public class MongoDbContext
    {
        public IMongoCollection<MachineAsset> MachineAssets { get; }

        public MongoDbContext(IConfiguration configuration)
        {
            try
            {
                var connectionString = configuration["MongoDbSettings:ConnectionString"];
                var databaseName = configuration["MongoDbSettings:DatabaseName"];
                var collectionName = configuration["MongoDbSettings:CollectionName"]; 

                var client = new MongoClient(connectionString);
                var database = client.GetDatabase(databaseName);
                MachineAssets = database.GetCollection<MachineAsset>(collectionName);

                var count = MachineAssets.CountDocuments(_ => true);
                Console.WriteLine($"MongoDB connected! Documents in collection: {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"MongoDB Connection Error: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                throw;
            }
        }
    }
}