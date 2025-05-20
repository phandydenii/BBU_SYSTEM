using System;
using BBU_SYSTEM.Data;
using BBU_SYSTEM.Respository;
using Microsoft.EntityFrameworkCore;

namespace BBU_SYSTEM_API.Service
{
	public class CampusDbContextService : ICampusDbContext
	{
        private readonly IConfiguration _configuration;

        public CampusDbContextService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CampusDbContext DbContext(string campusKey)
        {
            var connectionString = _configuration.GetConnectionString($"{campusKey}_campus");
            var optionsBuilder = new DbContextOptionsBuilder<CampusDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CampusDbContext(optionsBuilder.Options);
        }
    }
}

