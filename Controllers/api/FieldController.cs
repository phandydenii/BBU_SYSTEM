using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.api.Controllers;
[ApiController]
[Route("api/mis")]
public class FieldController : ControllerBase
{
    private readonly IField _service;
    private Http http = new Http();
    public FieldController(IField service)
    {
        this._service = service;
    }

    [HttpGet("{campus}/fields")]
    public IActionResult Get(string campus)
    {
        var data = _service.get(campus);
        return http.GetRes(data);
    }
    [HttpGet("{campus}/fields/{degree_id}/{school_id}")]
    public IActionResult Get(string campus,int degree_id,int school_id)
    {
        var data = _service.get(campus,degree_id,school_id);
        return http.GetRes(data);
    }
    [HttpGet("{campus}/fiels/{id}")]
    public IActionResult Get(string campus, int id)
    {
        var data = _service.get(campus, id);
        return http.GetRes(data);
    }

    [HttpPost("{campus}/fields")]
    public IActionResult Post(string campus, FieldDto req)
    {
        var data = _service.add(campus, req);
        return http.PostRes(data);
    }

    [HttpPut("{campus}/fields/{id}")]
    public IActionResult Update(string campus, int id, FieldDto req)
    {
        var data = _service.update(campus, id, req);
        return http.PutRes(data);
    }

    [HttpDelete("{campus}/fields/{id}")]
    public IActionResult Delete(string campus, int id)
    {
        var data = _service.delete(campus, id);
        return http.GetRes(data);
    }
}
