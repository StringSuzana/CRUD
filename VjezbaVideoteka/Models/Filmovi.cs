using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VjezbaVideoteka.Models
{
    public class Filmovi
    {
        [Key]
        public int FilmId { get; set; }
        [Required]
        public string  Naziv { get; set; }
        public bool Posudeno { get; set; }
    }
}