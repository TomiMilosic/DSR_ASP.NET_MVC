using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using naloga2.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
    
namespace naloga2.Models
{


    //
    public class Uporabnik
    {
        
        //[HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Ime { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string priimek { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime RojstniDan{ get; set; }
        [Required]
        public string KrajRojstva { get; set; }
        [Required]
        [Range(1000000000000, 9999999999999)]
        public Int64 emso { get; set; }
        [Required]
        [PreveriEmso(ErrorMessage ="emso ni pravilen!")]
        public Int32 starost { get; set; }
        [Required]
        public string Naslov{ get; set; }
        [Required]
        public Int32 PostnaStevilka{ get; set; }
        [Required]
        public string Posta { get; set; }
        [Required]
        public string Drzava { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
       


        public static IEnumerable<SelectListItem> GetKraji()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "Ptuj", Value = "Ptuj" });
            SelectListItem item = new SelectListItem();
            list.Add(item);
            yield return new SelectListItem { Text = "Maribor", Value = "Maribor" };
            yield return new SelectListItem { Text = "Ljubljana", Value = "Ljubljana" };
            yield return new SelectListItem { Text = "Litija", Value = "Litija", Selected = true };
            yield return new SelectListItem { Text = "Kranj", Value = "Kranj" };
            yield return new SelectListItem { Text = "Koper", Value = "Koper" };
        }


        public Uporabnik()
        {

        }
    }
}
