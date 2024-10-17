using DIYManagementAPI.Models;
using DIYManagementAPI.Models.DTO;
using DIYManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIYManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIYController : ControllerBase
    {
        private readonly DYIService _service;

        public DIYController(DYIService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<DIYAvondModel>> CreateDIYAvond([FromBody] DIYAvondCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var diyAvond = new DIYAvondModel
            {
                Title = dto.Title,
                ExtraInfo = dto.ExtraInfo,
                StartDate = dto.StartDate,
                StartTime = dto.StartTime,
                EndDate = dto.EndDate,
                EndTime = dto.EndTime
            };

            var result = await _service.CreateDIYAvond(diyAvond, dto.ReparateurIds);

            // Retourneer het resultaat; met ook nog een check voor zekerheid, maar omdat die nog niet bestaat; later
            //return CreatedAtAction(nameof(GetDIYAvondById), new { id = result.Id }, result);
            return StatusCode(StatusCodes.Status201Created, result);
        }

        // TODO: get all DIYAvondModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DIYAvondModel>>> GetDIYAvonden()
        {
            //var result = await _service.GetDIYAvonden();
            //return Ok(result);

            var fakeResult = new List<DIYAvondModel>
            {
               new DIYAvondModel { Id = 1, Title = "Test 1", ExtraInfo = "This is a test", StartDate = DateTime.Now, StartTime = new TimeSpan(10, 0, 0), EndDate = DateTime.Now, EndTime = new TimeSpan(12, 0, 0) },
               new DIYAvondModel { Id = 2, Title = "Test 2", ExtraInfo = "This is a test", StartDate = DateTime.Now, StartTime = new TimeSpan(10, 0, 0), EndDate = DateTime.Now, EndTime = new TimeSpan(12, 0, 0) },
            };

            return Ok(fakeResult);
        }

            // TODO: get specific DIYAvondModel by id
            // TODO: Annuleer meeting
            // TODO: meld aan als klant
        }
}
