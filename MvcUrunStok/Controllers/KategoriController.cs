using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcUrunStok.Models.Entity;

namespace MvcUrunStok.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcStokEntities db = new MvcStokEntities();
        public ActionResult Index()
        {
            var degerler=db.Kategoriler.ToList();
            return View(degerler);
        }
    }
}