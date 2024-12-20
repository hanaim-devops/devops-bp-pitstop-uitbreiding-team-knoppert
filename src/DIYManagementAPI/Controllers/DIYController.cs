﻿using DIYManagementAPI.Models;
using DIYManagementAPI.Models.DTO;
using DIYManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace DIYManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIYController : ControllerBase
    {
        
        private static readonly Counter RequestCounter = Metrics
        .CreateCounter("api_diy_getEvenings_request", "Total number of requests to DiyTestModels API");

        private readonly DIYService _service;

        private static readonly Histogram createDIYEveningDuration = Metrics
            .CreateHistogram("api_diy_CreateDIYEvening_duration_seconds", "Duration of CreateDIYEvening requests in seconds");

        private static readonly Counter getDIYEveningCounter = Metrics
            .CreateCounter("api_diy_getDIYEvening_counter", "Total number of get requests on a single evening");

        private static readonly Counter registerCustomerForDIYEveningCounter = Metrics
            .CreateCounter("api_diy_registerDIYEvening_counter", "Total amount of customers registered for a DIYEvening");

        public DIYController(DIYService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<DIYEveningModel>> CreateDIYEvening([FromBody] DIYEveningCreateDto dto)
        {
            using (createDIYEveningDuration.NewTimer())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _service.CreateDIYEvening(dto);

                return StatusCode(StatusCodes.Status201Created, result);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DIYEveningModel>>> GetDIYEvening()
        {
            RequestCounter.Inc();
            var result = await _service.GetDIYEvenings();
            return Ok(result);
        }

        [HttpGet("future")]
        public async Task<ActionResult<IEnumerable<DIYEveningModel>>> GetFutureDIYEvenings()
        {
            var result = await _service.GetFutureDIYEvenings();
            return Ok(result);
        }
           
        [HttpGet("{id}")]
        public async Task<ActionResult<DIYEveningModel>> GetDIYEveningById(int id)
        {
            getDIYEveningCounter.Inc();
            var result = await _service.GetDIYEveningById(id);
            return Ok(result);
        }

        [HttpPut("cancel/{id}")]
        public async Task<ActionResult<DIYEveningModel>> CancelDIYEvening(int id)
        {
            try
            {
                var result = await _service.CancelDIYEvening(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost("registercustomer")]
        public async Task<ActionResult> RegisterDIYEveningCustomer([FromBody] DIYRegistrationCreateDto dto)
        {
            registerCustomerForDIYEveningCounter.Inc();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.RegisterDIYEveningCustomer(dto);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("{id}/registrations")]
        public async Task<ActionResult<IEnumerable<DIYRegistration>>> GetRegistrationsForDIYEvening(int id)
        {
            var result = await _service.GetRegistrationsForDIYEvening(id);
            return Ok(result);
        }

        [HttpPost("cancelregistration/{diyRegistrationId}")]
        public async Task<ActionResult> CancelRegistration(int diyRegistrationId)
        {
            var result = await _service.CancelDIYRegistration(diyRegistrationId);

            if (result)
            {
                return NoContent();
            }

            return NotFound();
        }

        [HttpPost("registerfeedback")]
        public async Task<ActionResult<DIYEveningModel>> RegisterDIYFeedback([FromBody] DIYFeedbackCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.RegisterDIYFeedback(dto);

            return StatusCode(StatusCodes.Status201Created, null);
        }

        [HttpGet("customerhistory/{name}")]
        public async Task<ActionResult<IEnumerable<DIYCustomerHistoryDTO>>> GetCustomerHistory(string name)
        {
            var result = await _service.GetCustomerHistory(name);
            return Ok(result);
        }
        
        [HttpGet("getfeedback/{diyEveningId}")]
        public async Task<ActionResult<IEnumerable<DIYFeedback>>> GetFeedback(int diyEveningId)
        {
            var feedback = await _service.GetFeedbackAsync(diyEveningId);
            return Ok(feedback);
        }
    }
}
