using System;
namespace BBU_SYSTEM.Repository
{
	public interface IInvoice
	{
		public IEnumerable<object> get(string campus, DateTime fromdate, DateTime todate);
	}
}

