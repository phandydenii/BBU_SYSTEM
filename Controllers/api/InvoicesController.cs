using BBU_SYSTEM.Helper;
using BBU_SYSTEM.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers.api
{
    [Route("api/mis")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoice _service;
        private Http http = new Http();
        public InvoicesController(IInvoice service)
        {
            _service = service;
        }

        [HttpGet("{campus}/invoices/{from_date}/{to_date}")]
        public IActionResult Get(string campus, DateTime from_date, DateTime to_date)
        {
            var data = _service.get(campus, from_date, to_date);
            return http.GetRes(data);
        }
    }
}
