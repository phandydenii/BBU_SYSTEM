using System;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using BBU_SYSTEM.ViewModel;

namespace BBU_SYSTEM.Service
{
	public class BookingService : IBooking
	{
		private readonly ICampusDbContext campusDbContext;

        public BookingService(ICampusDbContext campusDbContext)
        {
            this.campusDbContext = campusDbContext;
        }

        public IEnumerable<object> Get(string campus, DateTime from, DateTime to)
		{
            var db = campusDbContext.DbContext(campus);
            var fromdate = Convert.ToDateTime(from.ToString("yyyy-MM-dd"));
            var todate = Convert.ToDateTime(to.ToString("yyyy-MM-dd"));
            var data = db.tbl_booking.Where(x=>x.bookingdate >=fromdate && x.bookingdate<=todate).ToList();
            return data;

		}
    }
}

