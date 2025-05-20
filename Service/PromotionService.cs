using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service;

public class PromotionService : IPromotion
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public PromotionService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> gets(string campus)
    {
        var data = _campusDbContext.DbContext(campus).tbl_promotion.ToList();
        return data!;
    }
    public object get(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_promotion.Where(x => x.promotion_id == id).FirstOrDefault();
        return data!;
    }
    public object add(string campus, PromotionDto req)
    {
        var dto = _mapper.Map<PromotionDto, Promotion>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_promotion.Add(dto);
        db.SaveChanges();
        return get(campus, dto.promotion_id);
    }
    public object update(string campus, int id, PromotionDto req)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return null!;

        var dto = _mapper.Map<PromotionDto, Promotion>(req);
        var db = _campusDbContext.DbContext(campus);
        db.tbl_promotion.Update(dto);
        db.SaveChanges();
        return get(campus, dto.promotion_id);
    }
    public bool delete(string campus, int id)
    {
        var dataExist = getid(campus, id);
        if (dataExist == null) return false;

        var db = _campusDbContext.DbContext(campus);
        db.tbl_promotion.Remove(dataExist);
        db.SaveChanges();
        return true;
    }

    public Promotion getid(string campus, int id)
    {
        var data = _campusDbContext.DbContext(campus).tbl_promotion.Where(x => x.promotion_id == id).FirstOrDefault();
        return data!;
    }
}
