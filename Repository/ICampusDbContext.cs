using System;
using BBU_SYSTEM.Data;

namespace BBU_SYSTEM.Respository
{
	public interface ICampusDbContext
	{
        CampusDbContext DbContext(string campusKey);
    }
}