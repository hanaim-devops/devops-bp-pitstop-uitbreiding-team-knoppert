﻿using DIYManagementAPI.Models;
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
        public async Task<ActionResult<DIYEveningModel>> CreateDIYEvening([FromBody] DIYEveningCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var diyEvening = new DIYEveningModel
            {
                Title = dto.Title,
                ExtraInfo = dto.ExtraInfo,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Mechanic = dto.Mechanic
            };

            var result = await _service.CreateDIYEvening(diyEvening);

            return StatusCode(StatusCodes.Status201Created, result);
        }

        // TODO: get all DIYEveningModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DIYEveningModel>>> GetDIYEvening()
        {
            var result = await _service.GetDIYEvenings();
            return Ok(result);
        }

        // TODO: get specific DIYAvondModel by id
        // TODO: Annuleer meeting
        // TODO: meld aan als klant
    }
}
