using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcUrunStok.Models.Entity;

namespace MvcUrunStok.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MvcStokEntities db = new MvcStokEntities();
        public ActionResult Index()
        {
            var degerler = db.Musteriler.ToList();
            return View(degerler);
        }
    }
}