using BusinessLayer.Concrete;
using DateAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager am = new AdminManager(new EfAdminDal());

        public ActionResult Index()
        {
            var adminvalues = am.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            List<SelectListItem> valueadmin = (from x in am.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.AdminRole,
                                                      Value = x.AdminID.ToString()
                                                  }).ToList();
            ViewBag.vla = valueadmin;
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin a)
        {
            am.AdminAdd(a);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalue = am.GetByID(id);
            return View(adminvalue);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            am.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}