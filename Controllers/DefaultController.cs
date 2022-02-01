using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TableExport_Pdf_Mvc_Word.Models.Entity;

namespace TableExport_Pdf_Mvc_Word.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        MyBlogDbEntities _db = new MyBlogDbEntities();
        public ActionResult Index()
        {
            var degerler = _db.Categories.ToList();

            return View(degerler);
        }

        public ActionResult GetFilterByName()
        {
            var degerler = _db.Set<Categories>().Where(c => c.IsActive == true).ToList();

            return View(degerler);
        }
    }
}