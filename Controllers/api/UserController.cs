using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Model.Req;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace BBU_SYSTEM_API.Controllers
{
    [ApiController]
    [Route("api/mis")]
    public class UserController : ControllerBase
    {
        private readonly IUser _service;
        private Http http = new Http();
        public UserController(IUser service)
        {
            this._service = service;
        }
        [HttpPost("{campus}/user/login")]
        public IActionResult Post(string campus,AuthReq req)
        {
            HttpContext.Session.SetString("campus", campus);
            var data = _service.login(campus, req);
            return http.PostRes(data);
        }

        [HttpPost("{campus}/user/register")]
        public IActionResult Post(string campus, UserDto req)
        {
            var data = _service.register(campus, req);
            return http.PostRes(data);
        }
    }
}

