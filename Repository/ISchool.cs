

using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Repository
{
    public interface ISchool
    {
        public IEnumerable<object> gets(string campus);
        public object get(string campus, int id);
        public object add(string campus, SchoolDto req);
        public object update(string campus, int id, SchoolDto req);
        public bool delete(string campus, int id);
    }
}   