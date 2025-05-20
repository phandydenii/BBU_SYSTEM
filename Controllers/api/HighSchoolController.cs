using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
	[Route("api/mis"),ApiController]
	public class HighSchoolController : ControllerBase
	{
        private readonly IHighSchool _service;
        private Http http = new Http();
        public HighSchoolController(IHighSchool service)
        {
            this._service = service;
        }
        [HttpGet("{campus}/high-schools")]
        public IActionResult Get(string campus)
        {
            var data = _service.get(campus);
            return http.GetRes(data);
        }
        [HttpGet("{campus}/high-schools/{id}")]
        public IActionResult Get(string campus, int id)
        {
            var data = _service.get(campus, id);
            return http.GetRes(data);
        }
        [HttpPost("{campus}/high-schools")]
        public IActionResult Post(string campus, HighSchoolDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }
    }
}

