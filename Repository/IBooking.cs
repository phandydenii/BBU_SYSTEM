using System;
using BBU_SYSTEM.ViewModel;

namespace BBU_SYSTEM.Repository
{
	public interface IBooking
	{
		public IEnumerable<object> Get(string campus, DateTime from, DateTime to);
	}
}

