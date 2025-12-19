namespace MachineWebApp.Services
{
    public class MachinesService
    {
        private readonly HttpClient _http;
        public readonly string apiUrl = "https://localhost:7052/api/assets";
        public MachinesService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<string>> GetAssetByMachine(string machineName)
        {
            return await _http.GetFromJsonAsync<List<string>>(apiUrl);
        }
        public async Task<List<string>> GetMachinesByAsset(string assetName)
        {
            return await _http.GetFromJsonAsync<List<string>>(apiUrl);

        }
        public async Task<List<string>> GetLatestSeriesMachine()
        {
            return await _http.GetFromJsonAsync<List<string>>(apiUrl);
        }
    }
}
