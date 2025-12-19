using MachineApi.Models;

namespace MachineApi.Data
{
    public interface IDatareader
    {
        List<MachineAsset> ReadData();
    }
}
