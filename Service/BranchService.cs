using AutoMapper;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service;

public class BranchService : IBranch
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public BranchService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> gets(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_branch.ToList();
        return data!;
    }
    public object get(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_branch.Where(x => x.branch_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, BranchDto req)
    {
        var dto = _mapper.Map<BranchDto, Branch>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_branch.Add(dto);
        db.SaveChanges();
        return get(campus, dto.branch_id);
    }
    public object update(string campus, int id, BranchDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<BranchDto, Branch>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_branch.Update(dto);
        db.SaveChanges();
        return get(campus, dto.branch_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_branch.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public Branch getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_branch.Where(x => x.branch_id == id).FirstOrDefault();
        return data!;
    } 
}
