using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service;

public class StageService : IStage
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public StageService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> gets(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_stage.ToList();
        return data!;
    }
    public object get(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_stage.Where(x => x.stage_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, StageDto req)
    {
        var dto = _mapper.Map<StageDto, Stage>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_stage.Add(dto);
        db.SaveChanges();
        return get(campus, dto.stage_id);
    }
    public object update(string campus, int id, StageDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<StageDto, Stage>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_stage.Update(dto);
        db.SaveChanges();
        return get(campus, dto.stage_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_stage.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public Stage getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_stage.Where(x => x.stage_id == id).FirstOrDefault();
        return data!;
    }
}
