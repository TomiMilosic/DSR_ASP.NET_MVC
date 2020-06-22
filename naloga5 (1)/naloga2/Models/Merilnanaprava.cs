using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using naloga2.DoubleBinder;

namespace naloga2.Models
{
    public class Merilnanaprava
    {

       
        public int Id { get; set; }
 
        public string Ime { get; set; }
      
        public double Zemljepisna_sirina { get; set; }
       
        public double Zemljepisna_dolzina { get; set; }

        public Merilnanaprava()
        {

        }
    }
}
