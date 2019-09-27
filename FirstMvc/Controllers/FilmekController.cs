using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvc.Models;
using FirstMvc.ViewModels;

namespace FirstMvc.Controllers
{
    public class FilmekController : Controller
    {
        // GET: Filmek
        public ActionResult Random()
        {


            var film = new Film() { Cim = "Nincs ilyen" };
            var kolcsonzok = new List<Kolcsonzo>() {
                new Kolcsonzo() { Nev = "Ricsi" },
                new Kolcsonzo() { Nev = "Lacika" },
                new Kolcsonzo() { Nev = "Sajt" },
                new Kolcsonzo() { Nev = "Sajt" },
                new Kolcsonzo() { Nev = "Sajt" }

            };
            var rfvm = new RandomFilmViewModel()
            {
                Film = film,
                Kolcsonzok = kolcsonzok

            };
            //ViewData["Film"] = film;
            //ViewBag.Film = film;
            return View(rfvm);
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
        [Route("Filmek/Megjelenes/{ev:regex(\\d{4})}/{honap:regex(\\d{2}):range(1, 12)}")]
        public ActionResult MegjenesSzerint(int ev=2000, int honap=01) {
            return Content($"év: {ev} | honap: {honap}");


        }

    }
}