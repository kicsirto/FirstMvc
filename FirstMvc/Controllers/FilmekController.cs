using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvc.Models;

namespace FirstMvc.Controllers
{
    public class FilmekController : Controller
    {
        // GET: Filmek
        public ActionResult Random()
        {


            var film = new Film() { Cim = "Nincs ilyen" };
            return View(film);
            //return Content("szeretem a tejet");
            //return HttpNotFound();
            //return RedirectToAction("About","Home", new { oldal=1, rendezes= "cim"});


        }

        public ActionResult Szerkesztes(int id)
        {
            return Content($"id = {id}");


        }

        public ActionResult Index(int oldal= 1 , string rendezes = "cim")
        {
            //if (!oldal.HasValue) oldal = 1;
            //if (string.IsNullOrWhiteSpace(rendezes)) rendezes = "cim";

            return Content($"oldalszám: {oldal} | rendezés: {rendezes}");


        }

        public ActionResult MegjenesSzerint(int ev, int honap) {
            return Content($"év: {ev} | honap: {honap}");


        }

    }
}