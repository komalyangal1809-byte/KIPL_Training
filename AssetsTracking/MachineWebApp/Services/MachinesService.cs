using System.Net.Http.Json;

namespace MachineWebApp.Services
{
    public class MachinesService
    {
        private readonly HttpClient _http;

        public MachinesService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<string>> GetAssetsByMachine(string machineName)
        {
            return await _http.GetFromJsonAsync<List<string>>(
                $"api/assets/machine/{Uri.EscapeDataString(machineName)}");
        }

        public async Task<List<string>> GetMachinesByAsset(string assetName)
        {
            return await _http.GetFromJsonAsync<List<string>>(
                $"api/assets/asset/{Uri.EscapeDataString(assetName)}");
        }

        public async Task<List<string>> GetLatestSeriesMachine()
        {
            return await _http.GetFromJsonAsync<List<string>>(
                "api/assets/latest");
        }

    }
}
