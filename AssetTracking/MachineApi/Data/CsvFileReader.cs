using MachineApi.Models;

namespace MachineApi.Data
{
    public class CsvFileReader
    {
        public List<MachineAsset> Read(string path)
        {
                var list = new List<MachineAsset>();

                var lines = File.ReadAllLines(path);

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    list.Add(new MachineAsset(parts[0].Trim(), parts[1].Trim(), parts[2].Trim()) );
                }

                return list;
         }
    }

}

