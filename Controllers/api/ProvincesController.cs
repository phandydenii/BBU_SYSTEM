using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers.api
{
    [Route("api/mis")]
    [ApiController]
    public class ProvincesController(IProvince service) : ControllerBase
    {
        private readonly Http _http = new Http();

        [HttpGet("{campus}/provinces")]
        public async Task<IActionResult> Get(string campus)
        {
            var data = await service.get(campus);
            return _http.GetRes(data);
        }

        [HttpGet("{campus}/provinces/{id}")]
        public async Task<IActionResult> Get(string campus, int id)
        {
            var data = await service.get(campus, id);
            return _http.GetRes(data);
        }
    }
}
