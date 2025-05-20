using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class DisabilityService : IDisability
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public DisabilityService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public object get(string campus)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = db.tbl_disability.ToList();
            return dt!;
        }
        public object get(string campus, int id)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = db.tbl_disability.Where(o => o.id == id).FirstOrDefault();
            return dt!;
        }
        public object add(string campus, DisabilityDto req)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = _mapper.Map<DisabilityDto, Disability>(req);
            db.tbl_disability.Add(dt);
            return get(campus, dt.id)!;
        }
    }
}

