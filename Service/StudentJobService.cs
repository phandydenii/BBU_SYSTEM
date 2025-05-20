using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class StudentJobService : IStudentJob
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public StudentJobService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public object get(string campus)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = db.tbl_student_job.ToList();
            return dt!;
        }
        public object get(string campus, int id)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = db.tbl_student_job.Where(o => o.job_id == id).FirstOrDefault();
            return dt!;
        }
        public object add(string campus, StudentJobDto req)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = _mapper.Map<StudentJobDto, StudentJob>(req);
            db.tbl_student_job.Add(dt);
            return get(campus, dt.job_id)!;
        }
    }
}

