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
        }
  
      
        public List<String> GetAssetByMachine(string  machineName)
        {
            if (!list.Any())
            {
                return new List<string>();
            }
            var asset = (from i in list
                        where i.MachineName == machineName
                        select i.AssetName).ToList();
            
            return asset;
        }
        public List<string> GetMachineByAsset(string assetName)
        {
           
            var machine = (from i in list
                        where i.AssetName == assetName
                        select i.MachineName).ToList();

            return machine;
        }
        public List<string> GetMachineUsingLatestSeries()
        {
            if(!list.Any())
            {
                return new List<string> ();
            }
            var orderlist = from i in list
                            orderby int.Parse(i.Series.Substring(1)) descending
                            select i.Series;
            var latestSeries=int.Parse(orderlist.First(). Substring(1));

            var machines = (from i in list
                           where int.Parse(i.Series.Substring(1)) == latestSeries
                           select i.MachineName).ToList();

            return machines;
        }
        
    }
}
