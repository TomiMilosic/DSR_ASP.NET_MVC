using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using naloga2.DoubleBinder;
namespace naloga2.Models
{
    //[ModelBinder(typeof(CutomModelBinder))]
    public class Meritve
    {
        
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Datum_meritve { get; set; }
        [Required]
        //[RegularExpression("/^(\\d+)(,\\d{1,2}|\\.\\d{1,2})?$/", ErrorMessage = "Use decimal only please")]
        public double Temparatura { get; set; }
        [Required]
        //[RegularExpression("/^(\\d+)(,\\d{1,2}|\\.\\d{1,2})?$/", ErrorMessage = "Use decimal only please")]
        public double Vlaznost { get; set; }
        [Required]
        public bool Okvara { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Use numbers only please")]
        public int ID_MLOG_TK { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Use numbers only please")]
        public int ID_NAPR_TK { get; set; }

        public Meritve()
        {
                
        }
    }
}
