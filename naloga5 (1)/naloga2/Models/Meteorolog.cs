using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naloga2.Models
{
    public class Meteorolog
    {
        //[HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public int LetoZaposlitve { get; set; }
        public Meteorolog()
        {

        }
    }
}
