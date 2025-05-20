using BBU_SYSTEM.Repository;
using BBU_SYSTEM.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BBU_SYSTEM.Helper;

namespace BBU_SYSTEM.api.Controllers;
[ApiController]
[Route("api/mis")]
public class BranchController : ControllerBase
{
    private readonly IBranch _service;
    private Http http = new Http(); 
    public BranchController(IBranch service)
    {
        this._service = service;
    }

    [HttpGet("{campus}/branchs")]
    public IActionResult Get(string campus)
    {
        var data = _service.gets(campus);
        return http.GetRes(data);
    }

    [HttpGet("{campus}/branchs/{id}")]
    public IActionResult Get(string campus, int id)
    {
        var data = _service.get(campus, id);
        return http.GetRes(data);
    }

    [HttpPost("{campus}/branchs")]
    public IActionResult Post(string campus, BranchDto req)
    {
        var data = _service.add(campus, req);
        return http.PostRes(data);
    }

    [HttpPut("{campus}/branchs/{id}")]
    public IActionResult Update(string campus, int id, BranchDto req)
    {
        var data = _service.update(campus, id, req);
        return http.PutRes(data);
    }

    [HttpDelete("{campus}/branchs/{id}")]
    public IActionResult Delete(string campus, int id)
    {
        var data = _service.delete(campus, id);
        return http.GetRes(data);
    }
}
