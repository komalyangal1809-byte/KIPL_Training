namespace MachineApi.Models
{
    public class MachineAsset
    {
        public string MachineName { get; set; }
        public string AssetName { get; set; }
        public string Series { get; set; }

        public MachineAsset(string machineName, string assetName, string series)
        {
            MachineName = machineName;
            AssetName = assetName;
            Series = series;
        }
    }

}
 