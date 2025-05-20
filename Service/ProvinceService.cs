using System;
using AutoMapper;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Respository;
using Microsoft.EntityFrameworkCore;

namespace BBU_SYSTEM.Service
{
	public class ProvinceService : IProvince
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public ProvinceService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<Province>> get(string campus)
        {
            var data = await _campusDbContext.DbContext(campus).tbl_province.ToListAsync();
            return data!;
        }
        public async Task<Province> get(string campus, int id)
        {
            var data = await _campusDbContext.DbContext(campus).tbl_province.FindAsync(id);
            return data!;
        }
    }
}

