using BBU_SYSTEM.Models;
using BBU_SYSTEM.Respository;
using BBU_SYSTEM.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBU_SYSTEM.Controllers;

public class AcademicController : Controller
{
    private readonly ICampusDbContext _campusDbContext;

    public AcademicController(ICampusDbContext campusDbContext)
    {
        _campusDbContext = campusDbContext;
    }

    public ActionResult AssignStudentGroup()
    {
        var campus = HttpContext.Session.GetString("campus");
        var db = _campusDbContext.DbContext(campus!);
        var degrees = db.tbl_degree.ToList();
        var schools = db.tbl_school.ToList();
        var fields = db.tbl_field.ToList();
        var promotions = db.tbl_promotion.ToList();
        var stages = db.tbl_stage.ToList();
        var terms = db.tbl_term.ToList();
        var groups = db.tbl_group.ToList();
        var groupRooms = db.tbl_group_room.ToList();

        var viewmodel = new StudentViewModel
        {
            degrees = degrees,
            schools = schools,
            fields = fields,
            promotions = promotions,
            stages = stages,
            groups = groups,
            groupRooms = groupRooms,
            terms = terms
        };
        return View(viewmodel);
    }


    public ActionResult ContinueEducation()
    {
        return View();
    }

    public ActionResult Course()
    {
        return View();
    }

    public ActionResult DoctoralContract()
    {
        return View();
    }

    public ActionResult GPA()
    {
        return View();
    }

    public ActionResult OtherBranchScore()
    {
        return View();
    }

    public ActionResult RequestQRCode()
    {
        return View();
    }

    public ActionResult ResetQRCode()
    {
        return View();
    }

    public ActionResult Room()
    {
        return View();
    }

    public ActionResult Score()
    {
        return View();
    }

    public ActionResult Student()
    {
        var campus = HttpContext.Session.GetString("campus");
        var db = _campusDbContext.DbContext(campus!);
        var degrees = db.tbl_degree.ToList();
        var schools = db.tbl_school.ToList();
        var fields = db.tbl_field.ToList();
        var promotions = db.tbl_promotion.ToList();
        var stages = db.tbl_stage.ToList();
        var terms = db.tbl_term.ToList();
        var groups = db.tbl_group.ToList();
        var groupRooms = db.tbl_group_room.ToList();

        var viewmodel = new StudentViewModel
        {
            degrees = degrees,
            schools = schools,
            fields = fields,
            promotions = promotions,
            stages = stages,
            groups = groups,
            groupRooms = groupRooms
        };
        return View(viewmodel);
    }

    [HttpPost]
    public IActionResult GetStudentList()
    {
        var draw = Request.Form["draw"].FirstOrDefault();
        var start = Request.Form["start"].FirstOrDefault();
        var length = Request.Form["length"].FirstOrDefault();
        var searchValue = Request.Form["search[value]"].FirstOrDefault();

        var pageSize = length != null ? Convert.ToInt32(length) : 0;
        var skip = start != null ? Convert.ToInt32(start) : 0;
        var campus = HttpContext.Session.GetString("campus");
        var db = _campusDbContext.DbContext(campus!);
        var query = db.tbl_student.AsQueryable();

        if (!string.IsNullOrEmpty(searchValue))
        {
            query = query.Where(d =>
                d.student_name!.Contains(searchValue) ||
                d.student_id.Contains(searchValue) ||
                d.student_name_in_khmer!.Contains(searchValue));
        }
            
        var recordsTotal = query.Count();
        query = query.OrderByDescending(d => d.student_id ?? "");
        var data = query.Skip(skip).Take(pageSize).ToList();

        return Json(new
        {
            draw,
            recordsFiltered = recordsTotal,
            recordsTotal,
            data
        });
    }

    public ActionResult Users()
    {
        return View();
    }

    [Route("academic/details")]
    [HttpGet]
    public ActionResult Details(string? student_id)
    {
        if (student_id == null) return NotFound();
        var db = _campusDbContext.DbContext(student_id.Substring(0, 2));
        var data = db.tbl_student.Where(o => o.student_id == student_id).FirstOrDefault();
        var pob = db.tbl_province.ToList();
        var races = db.tbl_race.ToList();
        var nationalities = db.tbl_nationality.ToList();
        var hightSchools = db.tbl_high_school.ToList();
        var studentJobs = db.tbl_student_job.ToList();
        var disabilities = db.tbl_disability.ToList();


        var studentgroup = db.tbl_student_group!.OrderByDescending(t => t.student_group_id)
            .Where(g => g.student_id == student_id).FirstOrDefault()!;
        var s = db.tbl_student!.Where(s => s.student_id == student_id).FirstOrDefault()!;
        var group = db.tbl_group!.Where(i => i.group_id == studentgroup!.group_id).FirstOrDefault()!;
        var group_room = db.tbl_group_room
            .Where(i => i.group_id == group!.group_id && i.term_no == studentgroup.term_no).FirstOrDefault()!;
        var stage = db.tbl_stage!.Where(g => g.stage_id == group!.stage_id).FirstOrDefault()!;
        var promotion = db.tbl_promotion!.Where(p => p.promotion_id == stage!.promotion_id).FirstOrDefault()!;
        var term = db.tbl_term!.Where(t => t.stage_id == stage!.stage_id && t.term_no == studentgroup!.term_no)
            .FirstOrDefault()!;
        var school = db.tbl_school!.Where(s => s.school_id == promotion!.school_id).FirstOrDefault()!;
        var degree = db.tbl_degree!.Where(d => d.degree_id == promotion!.degree_id).FirstOrDefault()!;
        var field = db.tbl_field!.Where(f => f.field_id == s!.field_id).FirstOrDefault()!;

        var studentAcademic = new StudentAcademic
        {
            student = s,
            studentGroup = studentgroup,
            group = group,
            stage = stage,
            promotion = promotion,
            term = term,
            school = school,
            degree = degree,
            field = field,
            groupRoom = group_room
        };
        if (data == null) return NotFound();

        var registrie = db.tbl_registry.FirstOrDefault(o => o.student_id == student_id);
        var degrees = db.tbl_degree.ToList();
        var schools = db.tbl_school.ToList();
        var fields = db.tbl_field.Where(o => o.degree_id == degree.degree_id && o.school_id == school.school_id)
            .ToList();
        var promotions = db.tbl_promotion.Where(o => o.degree_id == degree.degree_id && o.school_id == school.school_id)
            .ToList();
        var stages = db.tbl_stage.ToList();
        var terms = db.tbl_term.ToList();
        var groups = db.tbl_group.ToList();
        var groupRooms = db.tbl_group_room.ToList();

        var viewmodel = new StudentViewModel
        {
            Student = data,
            StudentAcademic = studentAcademic,
            provinces = pob,
            races = races,
            nationalities = nationalities,
            hightSchools = hightSchools,
            studentJobs = studentJobs,
            disabilities = disabilities,
            registry = registrie,
            degrees = degrees,
            schools = schools,
            fields = fields,
            promotions = promotions,
            stages = stages,
            groups = groups,
            groupRooms = groupRooms
        };
        return View(viewmodel);
    }
}