using System;
using AutoMapper;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using Microsoft.EntityFrameworkCore;

namespace BBU_SYSTEM.Service
{
	public class UniversityService : IUniversity
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public UniversityService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<University>> get(string campus)
		{
            var data = await _campusDbContext.DbContext(campus).tbl_usersity.ToListAsync();
            return data!;
        }
        public async Task<University> get(string campus, int id)
		{
            var data = await _campusDbContext.DbContext(campus).tbl_usersity.Where(x => x.university_id == id).FirstOrDefaultAsync();
            return data!;
        }
    }
}

