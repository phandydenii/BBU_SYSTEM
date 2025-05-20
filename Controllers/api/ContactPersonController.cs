using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers
{
    [Route("api/mis"), ApiController, Authorize]
    public class ContactPersonController : ControllerBase
    {
        private readonly IContactPerson _service;
        private Http http = new Http();
        public ContactPersonController(IContactPerson service)
        {
            this._service = service;
        }
        [HttpPost("{campus}/contact-person")]
        public IActionResult Post(string campus, ContactPersonDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }

    }
}

