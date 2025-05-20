using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class ExtendService : IExtend
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public ExtendService(ICampusDbContext campusDbContext, IMapper mapper)
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
            var dt = db.tbl_extend.Where(o => o.extend_id == id).FirstOrDefault();
            return dt!;
        }
        public object add(string campus, ExtendDto req)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = _mapper.Map<ExtendDto, Extend>(req);
            db.tbl_extend.Add(dt);
            return get(campus, dt.extend_id)!;
        }
    }
}

