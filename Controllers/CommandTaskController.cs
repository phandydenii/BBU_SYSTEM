using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Respository;
using BBU_SYSTEM.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers;

public class CommandTaskController : Controller
{
    private readonly ICampusDbContext campusDbContext;
    private readonly IMapper mapper;

    public CommandTaskController(ICampusDbContext _campusDbContext, IMapper _mapper)
    {
        campusDbContext = _campusDbContext;
        mapper = _mapper;
    }
    public IActionResult PromotionGroup()
    {
        var campus = HttpContext.Session.GetString("campus");
        var db = campusDbContext.DbContext(campus!);
        var degrees = db.tbl_degree.ToList();
        var schools = db.tbl_school.ToList();
        var fields = db.tbl_field.ToList();
        var promotions = db.tbl_promotion.Distinct().ToList();
        var stages = db.tbl_stage.ToList();
        var terms = db.tbl_term.ToList();
        var groups = db.tbl_group.ToList();
        var groupRooms = db.tbl_group_room.ToList();
        var data = new StudentViewModel
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
        return View(data);
    }

    public IActionResult Branch()
    {
        return View();
    }

    [HttpPost]
    public IActionResult GetDegreeList()
    {
        var draw = Request.Form["draw"].FirstOrDefault();
        var start = Request.Form["start"].FirstOrDefault();
        var length = Request.Form["length"].FirstOrDefault();
        var searchValue = Request.Form["search[value]"].FirstOrDefault();

        var pageSize = length != null ? Convert.ToInt32(length) : 0;
        var skip = start != null ? Convert.ToInt32(start) : 0;
        var campus = HttpContext.Session.GetString("campus");
        var db = campusDbContext.DbContext(campus!);
        var query = db.tbl_degree.AsQueryable();

        if (!string.IsNullOrEmpty(searchValue))
            query = query.Where(d =>
                d.degree!.Contains(searchValue) ||
                d.degree_in_khmer!.Contains(searchValue));

        var recordsTotal = query.Count();
        query = query.OrderByDescending(d => d.degree_id);
        var data = query.Skip(skip).Take(pageSize).ToList();

        return Json(new
        {
            draw,
            recordsFiltered = recordsTotal,
            recordsTotal,
            data
        });
    }

    public ActionResult Degree()
    {
        //var campus = HttpContext.Session.GetString("campus");
        //var db = campusDbContext.DbContext(campus!);
        //var data = db.tbl_degree.ToList();
        //var dataDto = mapper.Map<List<Degree>, List<DegreeDto>>(data);
        return View();
    }

    [HttpPost]
    public ActionResult Degree(DegreeDto req)
    {
        var campus = HttpContext.Session.GetString("campus");
        var db = campusDbContext.DbContext(campus!);
        var data = mapper.Map<DegreeDto, Degree>(req);
        using var tran = db.Database.BeginTransaction();
        try
        {
            db.tbl_degree.Add(data);
            db.SaveChanges();
            tran.Commit();
            TempData["Message"] = "Data saved successfully!";
            TempData["IsSuccess"] = true;
            
        }
        catch
        {
            tran.Rollback();
            TempData["Message"] = "An error occurred while saving.";
            TempData["IsSuccess"] = false;

        }

        return RedirectToAction("Degree", "CommandTask", true);
    }

    public ActionResult Disability()
    {
        return View();
    }

    public ActionResult Faculty()
    {
        return View();
    }

    public ActionResult Field()
    {
        return View();
    }

    public ActionResult FieldCertificate()
    {
        return View();
    }

    public ActionResult Nationality()
    {
        return View();
    }

    public ActionResult Province()
    {
        return View();
    }

    public ActionResult Race()
    {
        return View();
    }

    public ActionResult School()
    {
        return View();
    }

    public ActionResult University()
    {
        return View();
    }
}