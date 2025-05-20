using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class ContactPersonService : IContactPerson
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public ContactPersonService(ICampusDbContext campusDbContext, IMapper mapper)
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
            var dt = db.tbl_contact_person.Where(o => o.contact_person_id == id).FirstOrDefault();
            return dt!;
        }
        public object add(string campus, ContactPersonDto req)
        {
            var db = _campusDbContext.DbContext(campus);
            var dt = _mapper.Map<ContactPersonDto, ContactPerson>(req);
            db.tbl_contact_person.Add(dt);
            return get(campus,dt.contact_person_id)!;
        }
    }
}

