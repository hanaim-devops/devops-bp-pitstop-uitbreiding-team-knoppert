using Microsoft.AspNetCore.Mvc;
using DIYManagementAPI.Models;
using DIYManagementAPI.Services;
using Prometheus;

namespace DIYManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiyTestModelsController : ControllerBase
    {
        private static readonly Counter RequestCounter = Metrics
            .CreateCounter("api_diytestmodels_requests_total", "Total number of requests to DiyTestModels API");

        private readonly DiyTestModelService _service;

        public DiyTestModelsController(DiyTestModelService service)
        {
            _service = service;
        }

        // GET: api/DiyTestModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiyTestModel>>> GetListings()
        {
            // Increment the request counter when this endpoint is hit
            RequestCounter.Inc();

            var results = await _service.GetTestResults();
            return Ok(results);
        }
    }
}
