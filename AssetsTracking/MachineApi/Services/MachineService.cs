using System.Data;
using System.Net.Http.Json;
using MachineApi.Models;
using MachineApi.Data;

namespace MachineApi.Services
{
    public class MachineService 
    {
        private List<MachineAsset> list = new();
        public MachineService(IDatareader datareader) {

            list = datareader.ReadData(); Console.WriteLine("Records loaded: " + list.Count);

        }


        public List<String> GetAssetByMachine(string  machineName)
        {
            if (!list.Any())
            {
                return new List<string>();
            }
            var asset = (from i in list
                        where i.MachineName.Equals(machineName,StringComparison.OrdinalIgnoreCase)
                        select i.AssetName).ToList();
            
            return asset;
        }
        public List<string> GetMachineByAsset(string assetName)
        {
           
            var machine = (from i in list
                        where i.AssetName.Equals(assetName, StringComparison.OrdinalIgnoreCase)
                           select i.MachineName).ToList();

            return machine;
        }
        public List<string> GetMachineUsingLatestSeries()
        {
            if (!list.Any())
                return new List<string>();

            // 1. Find latest series for each asset
            var latestSeriesPerAsset = list
                .GroupBy(a => a.AssetName)
                .ToDictionary(
                    g => g.Key,
                    g => g.Max(x => int.Parse(x.Series.Substring(1)))
                );

            // 2. Check machines
            var result = new List<string>();

            var machines = list.Select(a => a.MachineName).Distinct();

            foreach (var machine in machines)
            {
                var machineAssets = list.Where(a => a.MachineName == machine);

                bool usesAllLatest = machineAssets.All(a =>
                    int.Parse(a.Series.Substring(1)) == latestSeriesPerAsset[a.AssetName]
                );

                if (usesAllLatest)
                    result.Add(machine);
            }

            return result;
        }
        
    }
}
