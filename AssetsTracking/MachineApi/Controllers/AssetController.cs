using Microsoft.AspNetCore.Mvc;
using MachineApi.Services;

namespace MachineApi.Controllers
{
    [ApiController]
    [Route("api/assets")]
    public class AssetController : ControllerBase
    {
        private readonly MachineService _service;

        public AssetController(MachineService service)
        {
            _service = service;
        }

        // a) Get assets by machine
        // URL: api/assets/machine/C300
        [HttpGet("machine/{machineName}")]
        public IActionResult GetAssetByMachine(string machineName)
        {
            return Ok(_service.GetAssetByMachine(machineName));
        }

        // b) Get machines by asset
        // URL: api/assets/asset/Shutter gripper
        [HttpGet("asset/{assetName}")]
        public IActionResult GetMachineByAsset(string assetName)
        {
            return Ok(_service.GetMachineByAsset(assetName));
        }

        // c) Latest series machines
        // URL: api/assets/latest
        [HttpGet("latest")]
        public IActionResult GetMachinesUsingLatestSeries()
        {
            return Ok(_service.GetMachineUsingLatestSeries());
        }
    }
}
