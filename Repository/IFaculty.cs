
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Repository;

public interface IFaculty
{
    public IEnumerable<object> gets(string campus);
    public object get(string campus, decimal id);
    public object add(string campus, FacultyDto req);
    public object update(string campus, int id, FacultyDto req);
    public bool delete(string campus, int id);
}