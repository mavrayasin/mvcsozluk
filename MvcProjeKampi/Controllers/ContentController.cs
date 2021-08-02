using BusinessLayer.Concrete;
using DateAccessLayer.Abstract;
using DateAccessLayer.Concrete;
using DateAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        //Context c = new Context();
        public ActionResult GetAllContent(string p)
        {
            // var values = from x in c.Contents select x;
            var values = cm.GetList(p);
            // if (!string.IsNullOrEmpty(p))
            //{
            //   values = values.Where(y => y.ContentValue.Contains(p));
            //}
            //var values = c.Contents.ToList();
           // return View(values.ToList());
            return View(values);

            //return View(values);
            //  tüm hepsi için yorum satırı

        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}