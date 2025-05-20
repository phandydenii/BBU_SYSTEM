
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Repository;

public interface IStage
{
    public IEnumerable<object> gets(string campus);
    public object get(string campus, int id);
    public object add(string campus, StageDto req);
    public object update(string campus, int id, StageDto req);
    public bool delete(string campus, int id);
}