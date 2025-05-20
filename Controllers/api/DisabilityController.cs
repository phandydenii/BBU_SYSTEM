using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
    [ApiController]
    [Route("api/mis")]
    public class DisabilityController : ControllerBase
	{
        private readonly IDisability _service;
        private Http http = new Http();
        public DisabilityController(IDisability service)
        {
            this._service = service;
        }
        [HttpGet("{campus}/disabilities")]
        public IActionResult Get(string campus)
        {
            var data = _service.get(campus);
            return http.GetRes(data);
        }
        [HttpGet("{campus}/disabilities/{id}")]
        public IActionResult Get(string campus, int id)
        {
            var data = _service.get(campus, id);
            return http.GetRes(data);
        }
        [HttpPost("{campus}/disabilities")]
        public IActionResult Post(string campus, DisabilityDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }
    }
}

