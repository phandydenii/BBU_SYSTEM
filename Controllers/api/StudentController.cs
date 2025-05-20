using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBU_SYSTEM.api.Controllers
{
    [Route("api/mis"),ApiController] 
    public class StudentController : ControllerBase
    {
        private readonly IStudent _service;
        private Http http = new Http();
        public StudentController(IStudent service)
        {
            this._service = service;
        }
        [HttpGet("{campus}/students/id/{student_id}")]
        public IActionResult Get(string campus, string student_id)
        {
            var data = _service.get(campus, student_id);
            return http.GetRes(data);
        }

        [HttpGet("{campus}/students/academics/{student_id}")]
        public IActionResult GetStudentAcademic(string campus, string student_id)
        {
            var data = _service.get_student_academic(campus, student_id);
            return http.GetRes(data);
        }

        [HttpGet("{campus}/students/name/{student_name}")]
        public IActionResult GetName(string campus, string student_name)
        {
            var data = _service.getname(campus, student_name);
            return http.GetRes(data);
        }
        [HttpGet("{campus}/students/filter/{group_id}/{term_no}")]
        public IActionResult GetName(string campus, int group_id, int term_no)
        {
            var data = _service.filter(campus, group_id,term_no);
            return http.GetRes(data);
        }
        [HttpGet("{campus}/students/name_khmer/{student_name_khmer}")]
        public IActionResult GetNameKm(string campus, string student_name_khmer)
        {
            var data = _service.get(campus, student_name_khmer);
            return http.GetRes(data);
        }
        [HttpPost("{campus}/students")]
        public IActionResult Post(string campus, StudentDto req)
        {
            var data = _service.add(campus, req);
            return http.PostRes(data);
        } 
    }
}

