using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers.api
{
    [Route("api/mis")]
    [ApiController]
    public class RacesController : ControllerBase
    {
        private readonly IRace _service;
        private Http http = new Http();
        public RacesController(IRace service)
        {
            this._service = service;
        }
        [HttpGet("{campus}/races")]
        public async Task<IActionResult> Get(string campus)
        {
            var data = await _service.get(campus);
            return http.GetRes(data);
        }

        [HttpGet("{campus}/races/{id}")]
        public async Task<IActionResult> Get(string campus, int id)
        {
            var data = await _service.get(campus, id);
            return http.GetRes(data);
        }
    }
}
