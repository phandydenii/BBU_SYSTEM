using AutoMapper;
using BBU_SYSTEM.Data;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Models.Req;
using BBU_SYSTEM.Respository;
using BBU_SYSTEM.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public AdministrationController(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            _mapper = mapper;
        }

        public ActionResult AdminLetter()
        {
            return View();
        }
        public ActionResult BookingClothes()
        {
            return View();
        }
        public ActionResult CategoryLetter()
        {
            return View();
        }

        public ActionResult GraduateCertificate()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult Users()
        {
            var campus = HttpContext.Session.GetString("campus");
            var db = _campusDbContext.DbContext(campus!);
            var data = db.tbl_user.ToList();
            return View(data);
        }

        public ActionResult Discount()
        {
            var campus = HttpContext.Session.GetString("campus")!;
            var db = _campusDbContext.DbContext(campus!);
            //var discountStudentIds = db.tbl_student_discount
            //                  .Select(d => d.student_id)
            //                  .Distinct()
            //                  .ToList();

            //// Filter students who are in the discount table
            //var studentsInDiscount = db.tbl_student
            //                           .Where(s => discountStudentIds.Contains(s.student_id))
            //                           .ToList();
            var data = (from s in db.tbl_student
                        join sd in db.tbl_student_discount on s.student_id equals sd.student_id
                        select new Student()
                        {
                            student_id = s.student_id,
                            student_name = s.student_name,
                            student_name_in_khmer = s.student_name_in_khmer,
                            sex = s.sex,
                            date_of_birth = s.date_of_birth,
                            phone = s.phone,
                            address = s.address,
                            email = s.email
                        }
                        ).Distinct().ToList();
            return View(data);
        }

        [HttpPost]
        [Route("Administration/GetStudentRegistryList")]
        public IActionResult GetStudentRegistryList(DateTime from, DateTime to)
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            var pageSize = length != null ? Convert.ToInt32(length) : 0;
            var skip = start != null ? Convert.ToInt32(start) : 0;
            var campus = HttpContext.Session.GetString("campus")!;
            var db = _campusDbContext.DbContext(campus!);


            var registry = db.tbl_registry.AsQueryable();
            if (from != DateTime.MinValue && to != DateTime.MinValue)
            {
                var fromdate = Convert.ToDateTime(from.ToString("yyyy-MM-dd"));
                var to_date = Convert.ToDateTime(to.ToString("yyyy-MM-dd"));
                registry = registry.Where(o => o.registration_date >= fromdate && o.registration_date <= to_date);
            }
            //if (!string.IsNullOrEmpty(searchValue))
            //{
            //    registry = registry.Where(d =>d.student_id!.Contains(searchValue));
            //}
            registry = registry.OrderByDescending(d => d.registration_id);
            var query = (from re in registry
                         join s in db.tbl_student on re.student_id equals s.student_id
                         join d in db.tbl_degree on re.degree_id equals d.degree_id
                         join sc in db.tbl_school on re.school_id equals sc.school_id
                         select new
                         {
                             s.student_id,
                             s.student_name,
                             s.student_name_in_khmer,
                             s.sex,
                             s.date_of_birth,
                             s.phone,
                             d.degree_id,
                             d.degree,
                             d.degree_in_khmer,
                             sc.school_id,
                             sc.school_name,
                             sc.school_name_in_khmer,
                             re.promotion_no,
                             re.stage_no,
                             re.term_no,
                             re.study_time,
                             re.registration_date,
                             re.high_school_result,
                             re.high_school_table_no
                         }).AsQueryable();

            if (!string.IsNullOrEmpty(searchValue))
            {
                query = query.Where(d =>
                    d.student_id!.Contains(searchValue) ||
                    d.student_name!.Contains(searchValue) ||
                    d.school_name!.Contains(searchValue) ||
                    d.degree.Contains(searchValue)
                );
            }
            var recordsTotal = query.Count();
            var data = query.Skip(skip).Take(pageSize).ToList();
            return Json(new
            {
                draw,
                recordsFiltered = recordsTotal,
                recordsTotal,
                data
            });
        }

        public ActionResult Registration()
        {
            var campus = HttpContext.Session.GetString("campus")!;
            var db = _campusDbContext.DbContext(campus!);
            var data = new RegistryViewModel()
            {
                degrees = db.tbl_degree.ToList(),
                schools = db.tbl_school.ToList(),
                fields = db.tbl_field.ToList(),
                promotions = db.tbl_promotion.ToList(),
                stages = db.tbl_stage.ToList(),
                terms = db.tbl_term.ToList(),
                groups = db.tbl_group.ToList(),
                studyTimes = db.tbl_study_time.ToList(),
                groupRooms = db.tbl_group_room.ToList(),
                rooms = db.tbl_room.ToList(),
                provinces = db.tbl_province.ToList(),
                nationalities = db.tbl_nationality.ToList(),
                races = db.tbl_race.ToList(),
                disabilities = db.tbl_disability.ToList(),
                hightSchools = db.tbl_high_school.ToList(),
                studentJobs = db.tbl_student_job.ToList(),
                studentCertificates = new List<StudentCertificateDto>(),
                schoolarships = new List<SchoolarshipDto>(),
                sponsors = db.tbl_sponsor.ToList(),
                student = new StudentDto(),
                contactPerson = new ContactPersonDto(),
                certificates = db.tbl_certificate.ToList()
            };

            return View(data);
        }

        [HttpPost]
        public ActionResult DoRegistry(RegistryViewModel req)
        {

            var student = _mapper.Map<StudentDto, Student>(req.student!);
            var registry = _mapper.Map<RegistryDto, Registry>(req.registry!);
            var contactPerson = _mapper.Map<ContactPersonDto, ContactPerson>(req.contactPerson!);
            var schoolarships = _mapper.Map<List<SchoolarshipDto>, List<Schoolarship>>(req.schoolarships!);
            var studentCertificates = _mapper.Map<List<StudentCertificateDto>, List<StudentCertificate>>(req.studentCertificates!);
            var extend = _mapper.Map<ExtendDto, Extend>(req.extend!);
            var resume = _mapper.Map<ResumeDto, Resume>(req.resume!);
            var campus = HttpContext.Session.GetString("campus")!;
            var db = _campusDbContext.DbContext(campus!);
            using var tran = db.Database.BeginTransaction();
            try
            {
                //db.tbl_student.Add(student);
                //db.tbl_registry.Add(registry);
                //db.tbl_contact_person.Add(contactPerson);

                //foreach (var dt in schoolarships)
                //{
                //    db.tbl_schoolarship.Add(dt);
                //}
                //foreach (var dt in studentCertificates)
                //{
                //    db.tbl_student_certificate.Add(dt);
                //}
                //db.tbl_extend.Add(extend);
                //if (req.ass_to_bach || req.bach_to_mas)
                //{
                //    db.tbl_resume.Add(resume);
                //}
                //db.SaveChanges();
                //tran.Commit();
                TempData["resul"] = true;
            }
            catch
            {
                tran.Rollback();
                TempData["resul"] = false;
            }
            return RedirectToAction(nameof(Registration));
        }
    }
}
