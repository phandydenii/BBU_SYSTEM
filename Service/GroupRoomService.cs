using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service;

public class GroupRoomService : IGroupRoom
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public GroupRoomService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> gets(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_group_room.ToList();
        return data!;
    }
    public object get(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_group_room.Where(x => x.group_room_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, GroupRoomDto req)
    {
        var dto = _mapper.Map<GroupRoomDto, GroupRoom>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_group_room.Add(dto);
        db.SaveChanges();
        return get(campus, dto.group_room_id);
    }
    public object update(string campus, int id, GroupRoomDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<GroupRoomDto, GroupRoom>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_group_room.Update(dto);
        db.SaveChanges();
        return get(campus, dto.group_room_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_group_room.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public GroupRoom getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_group_room.Where(x => x.group_room_id == id).FirstOrDefault();
        return data!;
    }
}
