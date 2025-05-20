
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Repository
{
    public interface IField
    {
        public IEnumerable<object> get(string campus);
        public object get(string campus, int id);
        public IEnumerable<object> get(string campus,int degree_id,int school_id);
        public object add(string campus, FieldDto req);
        public object update(string campus, int id, FieldDto req);
        public bool delete(string campus, int id);
    }
}