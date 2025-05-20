using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.DTO;
using Microsoft.AspNetCore.Mvc;
using BBU_SYSTEM.Helper;

namespace BBU_SYSTEM.api.Controllers
{
    [ApiController]
    [Route("api/mis")]
    public class DegreesController : ControllerBase
    {
        private readonly IDegree _service;
        private Http http =new Http();

        public DegreesController(IDegree degree)
        {
            this._service = degree;
        }

        [HttpGet("{campus}/degrees")] 
        public IActionResult Get(string campus)
        {
            var data = _service.gets(campus);
            return http.GetRes(data);
        }
         
        [HttpGet("{campus}/degrees/{id}")]
        public IActionResult Get(string campus, int id)
        {
            var data = _service.get(campus, id);
            return http.GetRes(data);
        }

        [HttpPost("{campus}/degrees")]
        public IActionResult Post(string campus, DegreeDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        }

        [HttpPut("{campus}/degrees/{id}")]
        public IActionResult Update(string campus, int id, DegreeDto req)
        {
            var data = _service.update(campus, id,req);
            return http.PutRes(data);
        }

        [HttpDelete("{campus}/degrees/{id}")]
        public IActionResult Delete(string campus, int id)
        {
            var data = _service.delete(campus,id);
            return http.GetRes(data);
        } 
    }
}

