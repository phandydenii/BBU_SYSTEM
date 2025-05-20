using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
	[Route("api/mis"),ApiController,Authorize]
	public class ResumeController : ControllerBase
	{
        private readonly IResume _service;
        private Http http = new Http();
        public ResumeController(IResume service)
        {
            this._service = service;
        }

        [HttpPost("{campus}/resumes")]
        public IActionResult Post(string campus, ResumeDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }

    }
}

