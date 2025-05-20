using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
    [Route("api/mis"), ApiController, Authorize]
    public class StudentCertificateController : ControllerBase
    {
        private readonly IStudentCertificate _service;
        private Http http = new Http();
        public StudentCertificateController(IStudentCertificate service)
        {
            this._service = service;
        }
        [HttpPost("{campus}/student-certificates")]
        public IActionResult Post(string campus, StudentCertificateDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }
    }
}

