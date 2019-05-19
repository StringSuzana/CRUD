using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VjezbaVideoteka.DAL;
using VjezbaVideoteka.Models;

namespace VjezbaVideoteka.Manager
{
    public class FilmoviManager
    {
        FilmoviRepo repo = new FilmoviRepo();

        public List<Filmovi> ListaFilmova ()
        {
            return repo.DohvatiSveFilmove();
        }

        public void BrisanjeFIlma (int id)
        {
            repo.IzbrisiFilm(id);
        }
        public void DodavanjeFilmova(Filmovi model)
        {
            repo.DodajFilm(model);
        }
        public void IzmjenaPodatakaFilma (Filmovi model)
        {
            repo.UpdateFilm(model);
        }
        public void IzmjeniBool (int id)
        {
            repo.IzmjeniBoolPosudeno(id);
        }
    }
}