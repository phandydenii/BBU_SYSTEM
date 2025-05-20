using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Mvc; 

namespace BBU_SYSTEM_API.Controllers;
[ApiController]
[Route("api/mis")]
public class FacultyController : ControllerBase
{
    private readonly IFaculty _service;
    private Http http = new Http();
    public FacultyController(IFaculty service)
    {
        this._service = service;
    }

    [HttpGet("{campus}/faculties")]
    public IActionResult Get(string campus)
    {
        var data = _service.gets(campus);
        return http.GetRes(data);
    }

    [HttpGet("{campus}/faculties/{id}")]
    public IActionResult Get(string campus, int id)
    {
        var data = _service.get(campus, id);
        return http.GetRes(data);
    }

    [HttpPost("{campus}/faculties")]
    public IActionResult Post(string campus, FacultyDto req)
    {
        var data = _service.add(campus, req);
        return http.PostRes(data);
    }

    [HttpPut("{campus}/faculties/{id}")]
    public IActionResult Update(string campus, int id, FacultyDto req)
    {
        var data = _service.update(campus, id, req);
        return http.PutRes(data);
    }

    [HttpDelete("{campus}/faculties/{id}")]
    public IActionResult Delete(string campus, int id)
    {
        var data = _service.delete(campus, id);
        return http.GetRes(data);
    }
}
