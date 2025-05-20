using System;
using AutoMapper;
using BBU_SYSTEM.Data;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class InvoiceService : IInvoice
	{
		private readonly ICampusDbContext campusDbContext;
		private readonly IMapper mapper;

        public InvoiceService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this.campusDbContext = campusDbContext;
            this.mapper = mapper;
        }

        public IEnumerable<object> get(string campus, DateTime fromdate, DateTime todate)
		{
            var db = campusDbContext.DbContext(campus);
            var from = Convert.ToDateTime(fromdate.ToString("yyyy-MM-dd"));
            var to = Convert.ToDateTime(todate.ToString("yyyy-MM-dd"));
            List<Invoice> data = db.tbl_invoice.Where(x => x.invoice_date >= from && x.invoice_date <= to).ToList();
            return data;
		}
    }
}

