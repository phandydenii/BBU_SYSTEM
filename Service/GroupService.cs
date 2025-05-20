using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM_API.Service;

public class GroupService : IGroup
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public GroupService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> gets(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_group.ToList();
        return data!;
    }
    public object get(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_group.Where(x => x.group_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, GroupDto req)
    {
        var dto = _mapper.Map<GroupDto, Group>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_group.Add(dto);
        db.SaveChanges();
        return get(campus, dto.group_id);
    }
    public object update(string campus, int id, GroupDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<GroupDto, Group>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_group.Update(dto);
        db.SaveChanges();
        return get(campus, dto.group_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_group.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public Group getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_group.Where(x => x.group_id == id).FirstOrDefault();
        return data!;
    }
}
