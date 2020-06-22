using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace naloga2.Models
{
    
    public class Baza : DbContext
    {
        public DbSet<Uporabnik> uporabniki { get; set; }
        public DbSet<Merilnanaprava> merilnanapravas{ get; set; }
        public DbSet<Meteorolog> meteorologs { get; set; }
        public DbSet<Meritve> Meritves{ get; set; }
    }
}
