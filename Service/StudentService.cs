using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BBU_SYSTEM.Service;

public class StudentService : IStudent
{
    private readonly ICampusDbContext _campusDbContext;
    private readonly IMapper _mapper;
    public StudentService(ICampusDbContext campusDbContext, IMapper mapper)
    {
        this._campusDbContext = campusDbContext;
        this._mapper = mapper;
    }
    public IEnumerable<object> get(string campus)
    {
        return null!;
    }
    public object get(string campus, string id)
    {
        var db = _campusDbContext.DbContext(campus);
        var dt = db.tbl_student.Where(o => o.student_id == id).FirstOrDefault();
        return dt!;
    } 
    public IEnumerable<object> getname(string campus, string name)
    {
        var db = _campusDbContext.DbContext(campus);
        var dt = db.tbl_student.Where(o => o.student_name!.Contains(name)).ToList();
        return dt!;
    }
    public IEnumerable<object> getnamekm(string campus, string name_khmer)
    {
        var db = _campusDbContext.DbContext(campus);
        var dt = db.tbl_student.Where(o => o.student_name!.Contains(name_khmer)).ToList();
        return dt!;
    }
    public object add(string campus, StudentDto req)
    {
        var db = _campusDbContext.DbContext(campus);
        var dt = _mapper.Map<StudentDto, Student>(req);
        db.tbl_student.Add(dt);
        return get(campus,dt.student_id)!;
    }

    public double Count(string campus)
    {
        var db = _campusDbContext.DbContext(campus); 
        return db.tbl_student.ToList().Count();
    }

    public double PageCount(string campus)
    {
        var db = _campusDbContext.DbContext(campus); 
        return Math.Ceiling((double)db.tbl_student.ToList().Count() / 10)!;
    }

    public IEnumerable<object> filter(string campus, int group_id, int term_no)
    {
        var db = _campusDbContext.DbContext(campus);
        List<StudentGroup> studentgroups = db.tbl_student_group!.Where(g => g.group_id == group_id && g.term_no==term_no).ToList()!;
        List<Student> students = new List<Student>();
        foreach(var sg in studentgroups)
        {
            students.Add(db.tbl_student.Find(sg.student_id)!);
        }
        return students;
    }

    public object get_student_academic(string campus, string student_id)
    {
        if (student_id == "") return null!;
        var db = _campusDbContext.DbContext(campus);
        Student student = db.tbl_student!.Where(s => s.student_id == student_id).FirstOrDefault()!;
        StudentGroup studentgroup = db.tbl_student_group!.OrderByDescending(t => t.student_group_id).Where(g => g.student_id == student_id).FirstOrDefault()!;
        Group group = db.tbl_group!.Where(i => i.group_id == studentgroup!.group_id).FirstOrDefault()!;
        GroupRoom group_room = db.tbl_group_room.Where(i => i.group_id == group!.group_id).FirstOrDefault()!;
        Stage stage = db.tbl_stage!.Where(g => g.stage_id == group!.stage_id).FirstOrDefault()!;
        Promotion promotion = db.tbl_promotion!.Where(p => p.promotion_id == stage!.promotion_id).FirstOrDefault()!;
        Term term = db.tbl_term!.Where(t => t.stage_id == stage!.stage_id && t.term_no == studentgroup!.term_no).FirstOrDefault()!;
        School school = db.tbl_school!.Where(s => s.school_id == promotion!.school_id).FirstOrDefault()!;
        Degree degree = db.tbl_degree!.Where(d => d.degree_id == promotion!.degree_id).FirstOrDefault()!;
        Field field = db.tbl_field!.Where(f => f.field_id == student!.field_id).FirstOrDefault()!;
        Nationality nationality = db.tbl_nationality!.Where(o => o.nationality_id == student.nationality_id).FirstOrDefault()!;
        Race race = db.tbl_race!.Where(o => o.race_id == student.race_id).FirstOrDefault()!;
        Province province = db.tbl_province!.Where(o => o.province_id == student.from_province_id).FirstOrDefault()!;
        var data = new
        {
            student,
            nationality,
            province,
            race,
            degree,
            school,
            field,
            field_type = field.type == true ? "Academic" : "Professional",
            promotion,
            stage,
            term,
            group,
            group_room
        };
        return data!;
    }
}
