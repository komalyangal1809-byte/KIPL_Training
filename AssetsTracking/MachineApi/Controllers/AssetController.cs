using Microsoft.AspNetCore.Mvc;

using MachineApi.Services;

namespace MachineApi.Controllers
{
    [ApiController]
    [Route("api/assets")]
    public class AssetController : ControllerBase
    {
        private MachineService _service;

        public AssetController(MachineService service)
        {
            _service = service;
        }
        [HttpGet("machine/{machineName}")]
        public IActionResult GetAssetByMachine(string machineName)
        {
            return Ok(_service.GetAssetByMachine(machineName));
        }
        [HttpGet("assets{assetName}")]
        public IActionResult GetMachineByAsset(string assetName)
        {
            return Ok(_service.GetMachineByAsset(assetName));
        }

        [HttpGet("MachineWithLatestSeries")]

        public IActionResult GetMachinesUsingLatestSeries()
        {
            return Ok(_service.GetMachineUsingLatestSeries());
        }
    }
}
