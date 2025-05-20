using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers.api
{
    [Route("api/mis")]
    [ApiController]
    public class FieldCertificatesController : ControllerBase
    {
        private readonly IFieldCertificate _service;
        private Http http = new Http();
        public FieldCertificatesController(IFieldCertificate service)
        {
            this._service = service;
        }

        [HttpGet("{campus}/field-certificate")]
        public async Task<IActionResult> Gets(string campus)
        {
            var data = await _service.get(campus);
            return http.GetRes(data);
        }
    }
}
