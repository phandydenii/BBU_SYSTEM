using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers;
[ApiController]
[Route("api/mis")]
public class StageController : ControllerBase
{
    private readonly IStage _service;
    private Http http = new Http();
    public StageController(IStage service)
    {
        this._service = service;
    }

    [HttpGet("{campus}/stages")]
    public IActionResult Get(string campus)
    {
        var data = _service.gets(campus);
        return http.GetRes(data);
    }

    [HttpGet("{campus}/stages/{id}")]
    public IActionResult Get(string campus, int id)
    {
        var data = _service.get(campus, id);
        return http.GetRes(data);
    }

    [HttpPost("{campus}/stages")]
    public IActionResult Post(string campus, StageDto req)
    {
        var data = _service.add(campus, req);
        return http.PostRes(data);
    }

    [HttpPut("{campus}/stages/{id}")]
    public IActionResult Update(string campus, int id, StageDto req)
    {
        var data = _service.update(campus, id, req);
        return http.PutRes(data);
    }

    [HttpDelete("{campus}/stages/{id}")]
    public IActionResult Delete(string campus, int id)
    {
        var data = _service.delete(campus, id);
        return http.GetRes(data);
    }
}
