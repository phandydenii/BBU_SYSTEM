using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
    [Route("api/mis"), ApiController]
    public class StudentJobController : ControllerBase
	{
        private readonly IStudentJob _service;
        private Http http = new Http();
        public StudentJobController(IStudentJob service)
        {
            this._service = service;
        }
        [HttpGet("{campus}/student-jobs")]
        public IActionResult Get(string campus)
        {
            var data = _service.get(campus);
            return http.GetRes(data);
        }
        [HttpGet("{campus}/student-jobs/{id}")]
        public IActionResult Get(string campus, int id)
        {
            var data = _service.get(campus, id);
            return http.GetRes(data);
        }
        [HttpPost("{campus}/student-jobs")]
        public IActionResult Post(string campus, StudentJobDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }
    }
}

