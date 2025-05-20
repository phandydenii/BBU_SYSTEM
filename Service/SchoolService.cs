using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service;

public class SchoolService : ISchool
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public SchoolService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> gets(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_school.ToList();
        return data!;
    }
    public object get(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_school.Where(x => x.faculty_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, SchoolDto req)
    {
        var dto = _mapper.Map<SchoolDto, School>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_school.Add(dto);
        db.SaveChanges();
        return get(campus, dto.school_id);
    }
    public object update(string campus, int id, SchoolDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<SchoolDto, School>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_school.Update(dto);
        db.SaveChanges();
        return get(campus, dto.school_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_school.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public School getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_school.Where(x => x.faculty_id == id).FirstOrDefault();
        return data!;
    }
}
