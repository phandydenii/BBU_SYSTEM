using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
    [Route("api/mis"), ApiController, Authorize]
    public class ExtendController : ControllerBase
    {
        private readonly IExtend _service;
        private Http http = new Http();
        public ExtendController(IExtend service)
        {
            this._service = service;
        }
        [HttpGet("{campus}/extends")]
        public IActionResult Get(string campus, int id)
        {
            var data = _service.get(campus, id);
            return http.GetRes(data);
        }
        [HttpPost("{campus}/extends")]
        public IActionResult Post(string campus, ExtendDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }
    }
}

