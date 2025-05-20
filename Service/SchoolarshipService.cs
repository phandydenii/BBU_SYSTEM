using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class SchoolarshipService : ISchoolarShip
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public SchoolarshipService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public IEnumerable<object> get(string campus)
        {
            return null!;
        }
        public object get(string campus, int id)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = db.tbl_schoolarship.Where(o => o.student_schoolarship_id == id).FirstOrDefault();
            return dt!;
        }
        public object add(string campus, SchoolarshipDto req)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = _mapper.Map<SchoolarshipDto, Schoolarship>(req);
            db.tbl_schoolarship.Add(dt);
            return get(campus, dt.student_schoolarship_id)!;
        }
    }
}

