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

            list = datareader.ReadData();
            Console.WriteLine("Records loaded: " + list.Count);

        }
        public List<String> GetAssetByMachine(string  machineName)
        {
            if (!list.Any())
            {
                return new List<string>();
            }
            var assets = list
                         .Where(machineAsset =>
                             machineAsset.MachineName.Equals(machineName, StringComparison.OrdinalIgnoreCase))
                         .Select(machineAsset => machineAsset.AssetName)
                         .ToList();

            return assets;
        }
        public List<string> GetMachineByAsset(string assetName)
        {
            if (!list.Any())
            {
                return new List<string>();
            }

            var machines = list
                         .Where(assetRecord =>
                             assetRecord.AssetName.Equals(assetName, StringComparison.OrdinalIgnoreCase))
                         .Select(machineAsset => machineAsset.MachineName)
                         .ToList();

            return machines;
        }
        public List<string> GetMachineUsingLatestSeries()
        {
            if (!list.Any())
                return new List<string>();


            var latestSeriesPerAsset = list
                                        .GroupBy(assetGroup => assetGroup.AssetName)
                                        .ToDictionary(
                                           groupRecord => groupRecord.Key,
                                           g => g.Max(x => x.Series)
                                        );

            var result = new List<string>();

            var machines = list.Select(a => a.MachineName).Distinct();

            foreach (var machine in machines)
            {
                var machineAssets = list.Where(machineAsset => machineAsset.MachineName == machine);

                bool usesAllLatest = machineAssets.All(a =>
                    a.Series == latestSeriesPerAsset[a.AssetName]
                );

                if (usesAllLatest)
                    result.Add(machine);
            }

            return result;


        }

    }
}
