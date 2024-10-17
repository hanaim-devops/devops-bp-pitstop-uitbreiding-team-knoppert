using DIYManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using DIYManagementAPI.Models;
using DIYManagementAPI.Models.DTO;
using DIYManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIYManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReperateurController : ControllerBase
    {
        //private readonly Service hier

        public ReperateurController()
        {

        }

        // GET: api/Reperateur
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reparateur>>> GetReperateurs()
        {
            //var result = await _service.GetReparateurs();
            //return Ok(result);

            var fakeResult = new List<Reparateur>
            {
               new Reparateur { Id = 1, Name = "Pietje Jansen"},
               new Reparateur { Id = 2, Name = "Klaasje Pietersen"},

            };
            return Ok(fakeResult);
        }

    }
}
