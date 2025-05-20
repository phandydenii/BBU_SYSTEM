using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
    [Route("api/mis"), ApiController, Authorize]
    public class SchoolarshipController : ControllerBase
    {
        private readonly ISchoolarShip _service;
        private Http http = new Http();
        public SchoolarshipController(ISchoolarShip service)
        {
            this._service = service;
        }
        [HttpPost("{campus}/student-schoolarships")]
        public IActionResult Post(string campus, SchoolarshipDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }
    }
}

