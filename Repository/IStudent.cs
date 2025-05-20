
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Repository;

public interface IStudent
{
    public IEnumerable<object> get(string campus);
    public object get_student_academic(string campus, string student_id);
    public object get(string campus,string id);
    public IEnumerable<object> getname(string campus,string name);
    public IEnumerable<object> filter(string campus,int group_id,int term_no);
    public IEnumerable<object> getnamekm(string campus,string name_khmer);
    public object add(string campus,StudentDto req);
}