using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service;

public class FacultyService : IFaculty
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public FacultyService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> gets(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_faculty.ToList();
        return data!;
    }
    public object get(string campus, decimal id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_faculty.Where(x => x.faculty_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, FacultyDto req)
    {
        var dto = _mapper.Map<FacultyDto, Faculty>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_faculty.Add(dto);
        db.SaveChanges();
        return get(campus, dto.faculty_id);
    }
    public object update(string campus, int id, FacultyDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<FacultyDto, Faculty>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_faculty.Update(dto);
        db.SaveChanges();
        return get(campus, dto.faculty_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_faculty.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public Faculty getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_faculty.Where(x => x.faculty_id == id).FirstOrDefault();
        return data!;
    }
}
