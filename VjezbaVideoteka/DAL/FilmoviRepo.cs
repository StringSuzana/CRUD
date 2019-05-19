using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VjezbaVideoteka.Models;

namespace VjezbaVideoteka.DAL
{
    public class FilmoviRepo
    {
        public List<Filmovi> DohvatiSveFilmove ()
        {
            using (var db = new ApplicationDbContext())
            {
                    return db.Filmovi.ToList();
                
            }
        }
        public void DodajFilm(Filmovi model)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Filmovi.Add(model);
                db.SaveChanges();
            }
        }


        public void IzbrisiFilm (int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var film = db.Filmovi.FirstOrDefault(b => b.FilmId == id);
                if (film != null)
                {
                    db.Filmovi.Remove(film);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateFilm (Filmovi model)
        {
            using (var db = new ApplicationDbContext())
            {
                var film = db.Filmovi.FirstOrDefault(b => b.FilmId == model.FilmId);
                if(film == null)
                {                 
                    return;
                }
                else
                {
                    film.Naziv = model.Naziv;
                    film.Posudeno = model.Posudeno;
                    db.SaveChanges();
                }
               

            }
        }
        public void IzmjeniBoolPosudeno (int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var film = db.Filmovi.FirstOrDefault(b => b.FilmId == id);
                if (film != null)
                {
                    film.Posudeno= !film.Posudeno;
                    db.SaveChanges();
                }
              

            }
        }
    }
}