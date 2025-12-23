using System.Net.Http.Json;

namespace MachineWebApp.Services
{
    public class MachinesService
    {
        private readonly HttpClient  _http;

        public MachinesService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<string>> GetAssetsByMachine(string machineName)
        {
            return await _http.GetFromJsonAsync<List<string>>(
                $"api/assets/machine/{Uri.EscapeDataString(machineName)}"  ) ?? new List<String>();
        }

        public async Task<List<string>> GetMachinesByAsset(string assetName)
        {
            return await _http.GetFromJsonAsync<List<string>>(
                $"api/assets/asset/{Uri.EscapeDataString(assetName)}") ?? new List<string>();
        }

        public async Task<List<string>> GetLatestSeriesMachine()
        {
            return await _http.GetFromJsonAsync<List<string>>(
                "api/assets/latest") ?? new List<string>();
        }

    }
}
