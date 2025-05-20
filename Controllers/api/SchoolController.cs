using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers;
[ApiController]
[Route("api/mis")]
public class SchoolController : ControllerBase
{
    private readonly ISchool _service;
    private Http http = new Http();
    public SchoolController(ISchool service)
    {
        this._service = service;
    }

    [HttpGet("{campus}/schools")]
    public IActionResult Get(string campus)
    {
        var data = _service.gets(campus);
        return http.GetRes(data);
    }

    [HttpGet("{campus}/schools/{id}")]
    public IActionResult Get(string campus, int id)
    {
        var data = _service.get(campus, id);
        return http.GetRes(data);
    }

    [HttpPost("{campus}/schools")]
    public IActionResult Post(string campus, SchoolDto req)
    {
        var data = _service.add(campus, req);
        return http.PostRes(data);
    }

    [HttpPut("{campus}/schools/{id}")]
    public IActionResult Update(string campus, int id, SchoolDto req)
    {
        var data = _service.update(campus, id, req);
        return http.PutRes(data);
    }

    [HttpDelete("{campus}/schools/{id}")]
    public IActionResult Delete(string campus, int id)
    {
        var data = _service.delete(campus, id);
        return http.GetRes(data);
    }
}
