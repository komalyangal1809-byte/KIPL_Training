using System.Text.Json;
using MachineApi.Models;
namespace MachineApi.Data
{
    public class JsonFileReader
    {
        public List<MachineAsset> Read(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<MachineAsset>>(json)
                   ?? new List<MachineAsset>();
        }
    }

}

