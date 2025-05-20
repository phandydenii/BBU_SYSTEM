using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service;

public class FieldService : IField
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public FieldService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> get(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_field.ToList();
        return data!;
    }
    public IEnumerable<object> get(string campus,int degree_id,int school_id)
    {
        var db = _campusDbContext.DbContext(campus);
        var data = (from f in db.tbl_field
                    join d in db.tbl_degree on f.degree_id equals d.degree_id
                    join s in db.tbl_school on f.school_id equals s.school_id
                    where f.degree_id==degree_id && f.school_id==school_id
                    select new
                    {
                        f.field_id,
                        f.field_name,
                        f.field_name_in_khmer,
                        degree = new
                        {
                            d.degree_id,
                            d.degree,
                            d.degree_in_khmer
                        },
                        school = new
                        {
                            s.school_id,
                            s.school_name,
                            s.school_name_in_khmer
                        }
                    }).ToList();
        return data!;
    }
    public object get(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_field.Where(x => x.field_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, FieldDto req)
    {
        var dto = _mapper.Map<FieldDto, Field>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_field.Add(dto);
        db.SaveChanges();
        return get(campus, dto.field_id);
    }
    public object update(string campus, int id, FieldDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<FieldDto, Field>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_field.Update(dto);
        db.SaveChanges();
        return get(campus, dto.field_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_field.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public Field getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_field.Where(x => x.field_id == id).FirstOrDefault();
        return data!;
    }
}
