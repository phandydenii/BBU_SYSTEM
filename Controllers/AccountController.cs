using BBU_SYSTEM.Model.Req;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICampusDbContext _campusDbContext;
        public AccountController(ICampusDbContext campusDbContext)
        {
            this._campusDbContext = campusDbContext;
        }
        // GET: AccountController
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(AuthReq model)
        {
            if (string.IsNullOrEmpty(model.campus))
            {
                ModelState.AddModelError("", "Campus selection is required.");
                return View(model);
            }
            var campus = model.campus;
            var db = _campusDbContext.DbContext(campus!);

            var user = db.tbl_user.FirstOrDefault(u =>u.user_name == model.username && u.password == model.password); // Hash in production

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials.");
                return View(model);
            }

            HttpContext.Session.SetString("campus", model.campus);
            HttpContext.Session.SetString("username", user.user_name!);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }

        
    }
}
