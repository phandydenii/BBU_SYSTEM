using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class ResumeService : IResume
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public ResumeService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public object get(string campus, int id)
        { 
            var db = _campusDbContext.DbContext(campus).tbl_resume.Where(o=>o.resume_id==id).FirstOrDefault();
            return db!;
        }
        public object add(string campus,ResumeDto req)
		{
            var dto = _mapper.Map<ResumeDto, Resume>(req);
            var db = _campusDbContext.DbContext(campus);
            db.tbl_resume.Add(dto);
            db.SaveChanges();
            return get(campus, dto.resume_id);
        }
    }
}

