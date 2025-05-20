using System;
using AutoMapper;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Respository;
using Microsoft.EntityFrameworkCore;

namespace BBU_SYSTEM.Service
{
	public class RaceService : IRace
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public RaceService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<Race>> get(string campus)
        {
            var data = await _campusDbContext.DbContext(campus).tbl_race.ToListAsync();
            return data!;
        }
        public async Task<Race> get(string campus, int id)
        {
            var data = await _campusDbContext.DbContext(campus).tbl_race.FindAsync(id);
            return data!;
        }
    }
}

