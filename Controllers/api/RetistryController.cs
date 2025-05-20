using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using BBU_SYSTEM.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
    [Route("api/mis"), ApiController]
    public class RetistryController : ControllerBase
	{
        private readonly IRegistry _service;
        private Http http = new Http();
        public RetistryController(IRegistry service)
        {
            this._service = service;
        }
        [HttpPost("{campus}/registries")]
        public IActionResult Post(string campus, RegistryDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }
        [HttpGet("{campus}/registries/{from_date}/{to_date}")]
        public IActionResult Get(string campus, DateTime from_date, DateTime to_date)
        {
            var data = _service.get(campus, from_date, to_date);
            return http.GetRes(data);
        }

        [HttpPatch("{campus}/registries/filter")]
        public IActionResult Get(string campus,FilterModel filter)
        {
            var data = _service.get(campus, filter);
            return http.GetRes(data);
        }
    }
}

