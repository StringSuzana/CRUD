using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VjezbaVideoteka.Manager;
using VjezbaVideoteka.Models;

namespace VjezbaVideoteka.Controllers
{
    public class FilmoviController : Controller
    {
        FilmoviManager manager = new FilmoviManager();
        // GET: Filmovi
        public ActionResult Index()
        {
            return View();
        }
        //[Authorize(Roles = "Admin")]
        public ActionResult SviFilmovi()
        {
            //if (Roles.IsUserInRole(User.Identity.Name, "Admin"))
            //{ 
            return View("FilmoviZaAdmina", manager.ListaFilmova());
            //}

            //else
            //{
               // return View(manager.ListaFilmova());
          //  }
        }

        [Route("IzbrisiFilm")]
        [HttpPost]
        public ActionResult IzbrisiFilm(int id)
        {
            manager.BrisanjeFIlma(id);
            return RedirectToAction("SviFilmovi");
        }

        [HttpPost]
        public void Izmjenibool(int id)
        {
            manager.IzmjeniBool(id);

          //  return RedirectToAction("SviFilmovi");

        }

        public ActionResult Update(int id)
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Update(Filmovi model)
        {
            manager.IzmjenaPodatakaFilma(model);
            return View();
        }



    }
}