using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers.api
{
    [Route("api/mis")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {
        private readonly IUniversity _service;
        private Http http = new Http();
        public UniversitiesController(IUniversity service)
        {
            this._service = service;
        }
        [HttpGet("{campus}/universities")]
        public async Task<IActionResult> Get(string campus)
        {
            var data = await _service.get(campus);
            return http.GetRes(data);
        }

        [HttpGet("{campus}/universities/{id}")]
        public async Task<IActionResult> Get(string campus, int id)
        {
            var data = await _service.get(campus, id);
            return http.GetRes(data);
        }
    }
}
