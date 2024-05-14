using APIGateway.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenceDataController : ControllerBase
    {
        private readonly IRefDataService _refDataService;

        public ReferenceDataController(IRefDataService refDataService)
        {
            _refDataService = refDataService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDataRequest()
        {
            return Ok(await _refDataService.GetDataAsync("8BDE7C98-518E-4C79-7528-08DC5A4C88C7"));
        }

        [HttpPost]
        public async Task<IActionResult> PostDirectorsAsync([FromBody] string directorName)
        {
            var test = await _refDataService.PostData(directorName);
            return Ok(test);
        }
    }
}
