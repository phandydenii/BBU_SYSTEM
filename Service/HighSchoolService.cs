using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class HighSchoolService : IHighSchool
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public HighSchoolService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public object get(string campus)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = db.tbl_high_school.ToList();
            return dt!;
        }
        public object get(string campus, int id)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = db.tbl_high_school.Where(o => o.high_school_id == id).FirstOrDefault();
            return dt!;
        }
        public object add(string campus, HighSchoolDto req)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = _mapper.Map<HighSchoolDto, HightSchool>(req);
            db.tbl_high_school.Add(dt);
            return get(campus, dt.high_school_id)!;
        }
    }
}

