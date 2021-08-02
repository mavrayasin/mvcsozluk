using EntityLayer.Concrete;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<Categoryclass> BlogList()
        {
            List<Categoryclass> ct = new List<Categoryclass>();
            ct.Add(new Categoryclass()
            {
                CategoryName="Yazılım",
                CategoryCount=8
            });
            ct.Add(new Categoryclass()
            {
                CategoryName = "Seyahat",
                CategoryCount = 4
            });
            ct.Add(new Categoryclass()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 7
            });
            ct.Add(new Categoryclass()
            {
                CategoryName = "Spor",
                CategoryCount = 1
            });
            return ct;
        }
    }
}