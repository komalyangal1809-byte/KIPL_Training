using MachineApi.Models;
using MachineApi.Settings;
using MongoDB.Driver;

namespace MachineApi.Data
{
    public class MongoDataReader : IDatareader
    {
        private readonly MongoDbContext _context;

        public MongoDataReader(MongoDbContext context)
        {
            _context = context;
        }

        public List<MachineAsset> ReadData()
        {
            return _context.MachineAssets.Find(_ => true).ToList();
        }
    }
}
