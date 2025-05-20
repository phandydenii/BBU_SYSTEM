using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers;

[ApiController]
[Route("api/mis")]
public class TermController : ControllerBase
{
    private readonly ITerm _service;
    private Http http = new Http();
    public TermController(ITerm service)
    {
        this._service = service;
    }

    [HttpGet("{campus}/terms")]
    public IActionResult Get(string campus)
    {
        var data = _service.gets(campus);
        return http.GetRes(data);
    }

    [HttpGet("{campus}/terms/{id}")]
    public IActionResult Get(string campus, int id)
    {
        var data = _service.get(campus, id);
        return http.GetRes(data);
    }

    [HttpPost("{campus}/terms")]
    public IActionResult Post(string campus, TermDto req)
    {
        var data = _service.add(campus, req);
        return http.PostRes(data);
    }

    [HttpPut("{campus}/terms/{id}")]
    public IActionResult Update(string campus, int id, TermDto req)
    {
        var data = _service.update(campus, id, req);
        return http.PutRes(data);
    }

    [HttpDelete("{campus}/terms/{id}")]
    public IActionResult Delete(string campus, int id)
    {
        var data = _service.delete(campus, id);
        return http.GetRes(data);
    }
}
