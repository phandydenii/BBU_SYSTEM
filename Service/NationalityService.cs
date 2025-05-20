using System;
using AutoMapper;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using Microsoft.EntityFrameworkCore;

namespace BBU_SYSTEM.Service
{
	public class NationalityService : INationality
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public NationalityService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<Nationality>> get(string campus)
        {
            var data = await _campusDbContext.DbContext(campus).tbl_nationality.ToListAsync();
            return data!;
        }
        public async Task<Nationality> get(string campus, int id)
        {
            var data = await _campusDbContext.DbContext(campus).tbl_nationality.FindAsync(id);
            return data!;
        }
    }
}

