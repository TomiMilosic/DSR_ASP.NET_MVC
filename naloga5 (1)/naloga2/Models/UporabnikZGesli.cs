using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static naloga2.Models.Uporabnik;

namespace naloga2.Models
{
    [NotMapped]
    public class UporabnikZGesli : Uporabnik
    {
        [Required]
        public  string Geslo { get; set; }
        [Required]
        [Compare(nameof(Geslo), ErrorMessage = "geslo mismatch")]
        public  string Geslo2 { get; set; }

        public UporabnikZGesli()
        {

        }
    }
}
