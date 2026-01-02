using MachineApi.Data;
using MachineApi.Models;
using MongoDB.Driver;

namespace MachineApi.Services
{
    public class DataImportService
    {
        private readonly MongoDbContext _context;

        public DataImportService(MongoDbContext context)
        {
            _context = context;
        }

        public void LoadFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var assets = new List<MachineAsset>();

            foreach (var line in lines.Skip(1)) 
            {
                var parts = line.Split(',');

                var asset = new MachineAsset(parts[0].Trim(), parts[1].Trim(), parts[2].Trim()) ;

                assets.Add(asset);
            }

            if (assets.Any())
            {
             
                _context.MachineAssets.DeleteMany(Builders<MachineAsset>.Filter.Empty);

               
                _context.MachineAssets.InsertMany(assets);
            }
        }
    }
}
