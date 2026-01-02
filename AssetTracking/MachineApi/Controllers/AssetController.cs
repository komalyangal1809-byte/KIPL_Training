using Microsoft.AspNetCore.Mvc;
using MachineApi.Services;

namespace MachineApi.Controllers
{
    [ApiController]
    [Route("api/assets")]
    public class AssetController : ControllerBase
    {
        private readonly MachineService _service;


        public AssetController(MachineService service )
        {
            _service = service;
           
        }


        [HttpGet("machine/{machineName}")]
        public IActionResult GetAssetByMachine(string machineName)
        {
            return Ok(_service.GetAssetByMachine(machineName));
        }


        [HttpGet("asset/{assetName}")]
        public IActionResult GetMachineByAsset(string assetName)
        {
            return Ok(_service.GetMachineByAsset(assetName));
        }


        [HttpGet("latest")]
        public IActionResult GetMachinesUsingLatestSeries()
        {
            return Ok(_service.GetMachineUsingLatestSeries());
        }

        [HttpPost("upload")]
        public IActionResult UploadCsvFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is empty");

            var extension=Path.GetExtension(file.FileName).ToLower();


            if (extension!=".csv" && extension!=".json")
                return BadRequest("Only CSV & JSON allowed");

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Data");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var fileName = extension == ".csv" ? "Matrix.csv" : "Matrix.json";

            var filePath = Path.Combine(folderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            _service.uplaodFile(filePath);
            return Ok();

        }

        [HttpGet("GetALlMachines")]
        public IActionResult GetAll()
        {
            var data = _service.GetAllMachines();
            return Ok(data);
        }


    }
}
