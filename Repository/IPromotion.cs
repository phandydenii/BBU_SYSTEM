
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Repository;

public interface IPromotion
{
    public IEnumerable<object> gets(string campus);
    public object get(string campus, int id);
    public object add(string campus, PromotionDto req);
    public object update(string campus, int id, PromotionDto req);
    public bool delete(string campus, int id);
}