using System;
using AutoMapper;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class DegreeService : IDegree
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public DegreeService(ICampusDbContext campusDbContext,IMapper mapper)
		{
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
		}

        public IEnumerable<object> gets(string campus)
        {
            var data = _campusDbContext.DbContext(campus).tbl_degree.ToList(); 
            return data!;
        }
        public object get(string campus,int id)
        {
            var data = _campusDbContext.DbContext(campus).tbl_degree.Where(x=>x.degree_id==id).FirstOrDefault();
            return data!;
        }
        public object add(string campus,DegreeDto req)
        {
            var dto = _mapper.Map<DegreeDto, Degree>(req);
            var db = _campusDbContext.DbContext(campus);
            db.tbl_degree.Add(dto);
            db.SaveChanges();
            return get(campus, dto.degree_id);
        }
        public object update(string campus,int id,DegreeDto req)
        {
            var dataExist = getid(campus, id);
            if (dataExist == null) return null!;

            var dto = _mapper.Map<DegreeDto, Degree>(req);
            var db = _campusDbContext.DbContext(campus);
            db.tbl_degree.Update(dto);
            db.SaveChanges();
            return get(campus, dto.degree_id);
        }
        public bool delete(string campus,int id)
        {
            var dataExist = getid(campus, id);
            if (dataExist == null) return false;
             
            var db = _campusDbContext.DbContext(campus);
            db.tbl_degree.Remove(dataExist);
            db.SaveChanges(); 
            return true;
        }

        public Degree getid(string campus, int id)
        {
            var data = _campusDbContext.DbContext(campus).tbl_degree.Where(x => x.degree_id == id).FirstOrDefault();
            return data!;
        }
    }
}

