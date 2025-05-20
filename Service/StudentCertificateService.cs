using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{ 
	public class StudentCertificateService : IStudentCertificate
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public StudentCertificateService(ICampusDbContext campusDbContext, IMapper mapper)
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
            var dt = db.tbl_student_certificate.Where(o => o.student_certificate_id == id).FirstOrDefault();
            return dt!;
        }
        public object add(string campus, StudentCertificateDto req)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = _mapper.Map<StudentCertificateDto, StudentCertificate>(req);
            db.tbl_student_certificate.Add(dt);
            return get(campus, dt.student_certificate_id)!;
        }
    }
}

