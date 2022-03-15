using _14032022_DropDownList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14032022_DropDownList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.SecilenSehirID = -1;
            ViewBag.SecilenUlkeID = -1;
            SelectList secilensehir = new SelectList(Sehir.SehirData(), "SehirId", "SehirAdi");

            ViewBag.SehirBilgi = secilensehir;

            SelectList secilenulke = new SelectList(Ulke.UlkeData(), "UlkeID", "UlkeAdi");

            ViewBag.UlkeBilgi = secilenulke;
          
            return View();
        }

        [HttpPost]
        public ActionResult Index(int SecilenSehir, int SecilenUlke)
        {
            ViewBag.SecilenSehirID = SecilenSehir;
            ViewBag.SecilenUlkeID = SecilenUlke;

            SelectList secilensehir = new SelectList(Sehir.SehirData(), "SehirId", "SehirAdi");

            ViewBag.SehirBilgi = secilensehir;

            SelectList secilenulke = new SelectList(Ulke.UlkeData(), "UlkeID", "UlkeAdi");

            ViewBag.UlkeBilgi = secilenulke;


            return View();
        }

        public ActionResult Index2()
        {
            IndexViewModal indexmodel = new IndexViewModal()
            {
                Sehir = new SelectList(Sehir.SehirData(), "SehirId", "SehirAdi"),
                Ulke = new SelectList(Ulke.UlkeData(), "UlkeID", "UlkeAdi"),
                SecilenSehirID = -1,
                SecilenUlkeID=-1
            };

            return View(indexmodel);
        }

        [HttpPost]
        public ActionResult Index2(IndexViewModal imodel)
        {
            imodel.Sehir = new SelectList(Sehir.SehirData(), "SehirId", "SehirAdi");
            imodel.Ulke = new SelectList(Ulke.UlkeData(), "UlkeID", "UlkeAdi");
            return View(imodel);
        }
        // ID:1;Adı:İstanbul
        public JsonResult SehirGetir(int id)
        {
            List<Sehir> sehirler = Sehir.SehirData().Where(x => x.UlkeID == id).ToList();

            return Json(sehirler,JsonRequestBehavior.AllowGet);
        }


    }
}