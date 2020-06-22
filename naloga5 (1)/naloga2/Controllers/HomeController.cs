using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using naloga2.Models;

namespace naloga2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }




       
        public IActionResult Meteorolog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Meteorolog(Meteorolog meteorolog)
        {
            if (ModelState.IsValid)
            {   
                using (var db = new Baza())
                {
                    db.meteorologs.Add(meteorolog);
                    db.SaveChanges();
                }

                return RedirectToAction("PrikazMeteorologov");
            }
            else
            {
                return View(meteorolog);
            }
           
        }
        [HttpGet]
        public IActionResult PrikazMeteorologov()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditMeteorolog(int id)
        {
            id++;

            using (var db= new Baza())
            {
                foreach (var item in db.meteorologs)
                {
                    if (item.Id==id)
                    {
                        db.SaveChanges();
                        return View(item);
                    }
                }
            }

            return View();
        }
        [HttpPost]
        public IActionResult EditMeteorolog(Meteorolog meteorolog)
        {
            using (var db = new Baza())
            {
                foreach (var item in db.meteorologs)
                {
                    if (item.Id == meteorolog.Id)
                    {
                        item.Ime = meteorolog.Ime;
                        item.Priimek = meteorolog.Priimek;
                        item.LetoZaposlitve = meteorolog.LetoZaposlitve;

                        break;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("PrikazMeteorologov");
        }
        public IActionResult DeleteMeteorolog(int id)
        {
            id++;
            using (var db = new Baza())
            {

                foreach (var item in db.meteorologs)
                {
                    if (item.Id == id)
                    {
                        db.meteorologs.Remove(item);

                        break;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("PrikazMeteorologov");
        }
        public IActionResult IzpisMeteorologa(int id) 
        {
            id++;
            Meteorolog meteorolog= new Meteorolog();
            using (var db = new Baza())
            {
                //db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Uporabniks', RESEED, 0)");
                foreach (var item in db.meteorologs.ToList())
                {
                   

                    if (item.Id == id)
                    {
                        meteorolog = item;
                    }
                }


            }
            return View(meteorolog);
        }

        //Izpis podrobnosti se









        public IActionResult Merilnanaprava()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Merilnanaprava(Merilnanaprava merilnanaprava)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Baza())
                {
                    db.merilnanapravas.Add(merilnanaprava);
                    db.SaveChanges();
                }

                return RedirectToAction("PrikazMerilnihNaprav");
            }
            else
            {
                return View(merilnanaprava);
            }
        }

        public IActionResult PrikazMerilnihNaprav()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditMerilnaNaprava(int id)
        {
            id++;

            using (var db = new Baza())
            {
                foreach (var item in db.merilnanapravas)
                {
                    if (item.Id == id)
                    {
                        db.SaveChanges();
                        return View(item);
                    }
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult EditMerilnaNaprava(Merilnanaprava merilnanaprava)
        {
            using (var db = new Baza())
            {
                foreach (var item in db.merilnanapravas)
                {
                    if (item.Id == merilnanaprava.Id)
                    {
                        item.Ime = merilnanaprava.Ime;
                        item.Zemljepisna_dolzina = merilnanaprava.Zemljepisna_dolzina;
                        item.Zemljepisna_sirina = merilnanaprava.Zemljepisna_sirina;
                        break;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("PrikazMerilnihNaprav");
        }

        public IActionResult DeleteMerilnaNaprava(int id)
        {
            id++;
            using (var db = new Baza())
            {
                foreach (var item in db.merilnanapravas)
                {
                    db.merilnanapravas.Remove(item);

                }
                db.SaveChanges();

                foreach (var item in db.merilnanapravas)
                {
                    if (item.Id == id)
                    {
                        
                        db.merilnanapravas.Remove(item);
                        break;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("PrikazMerilnihNaprav");
        }

        public IActionResult IzpisMerilnaNaprava(int id)
        {
            id++;
            Merilnanaprava merilnanaprava = new Merilnanaprava();
            using (var db = new Baza())
            {
                //db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Uporabniks', RESEED, 0)");
                foreach (var item in db.merilnanapravas.ToList())
                {


                    if (item.Id == id)
                    {
                        merilnanaprava = item;
                    }
                }


            }
            return View(merilnanaprava);
        }










      


        [HttpGet]
        public IActionResult Meritve()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Meritve(Meritve meritve)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Baza())
                {
                    db.Meritves.Add(meritve);
                    db.SaveChanges();
                }

                return RedirectToAction("prikazMeritev");
            }
            else
            {
                return View(meritve);
            }

        }

        public IActionResult prikazMeritev()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditMeritve(int id)
        {
            id++;

            using (var db = new Baza())
            {
                foreach (var item in db.Meritves)
                {
                    if (item.Id == id)
                    {
                        db.SaveChanges();
                        return View(item);
                    }
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult EditMeritve(Meritve meritve)
        {

            using (var db = new Baza())
            {
                foreach (var item in db.Meritves)
                {
                    if (item.Id == meritve.Id)
                    {
                        item.ID_MLOG_TK = meritve.ID_MLOG_TK;
                        item.ID_NAPR_TK = meritve.ID_NAPR_TK;
                        item.Okvara = meritve.Okvara;
                        item.Temparatura = meritve.Temparatura;
                        item.Vlaznost = meritve.Vlaznost;
                        break;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("prikazMeritev");
        }

        public IActionResult Deletemeritve(int id)
        {
            id++;
            using (var db = new Baza())
            {

                foreach (var item in db.Meritves)
                {
                    if (item.Id == id)
                    {
                        db.Meritves.Remove(item);
                        break;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("prikazMeritev");
        }


        public IActionResult izpisMeritev(int id)
        {
            id++;
            Meritve naprava = new Meritve();
            using (var db = new Baza())
            {
                //db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Uporabniks', RESEED, 0)");
                foreach (var item in db.Meritves.ToList())
                {
                    if (item.Id == id)
                    {
                        naprava = item;
                    }
                }
            }
            return View(naprava);
        }

       
















        [HttpGet]
        public IActionResult Edit(int id)
        {
            id++;
            using (var db = new Baza())
            {
                foreach (var item in db.uporabniki.ToList())
                {
                    if (item.Id== id)
                    {
                        db.SaveChanges();
                        return View(item);
                        
                    }
                }
            }

            return View();

        }
        [HttpPost]
        public IActionResult Edit(Uporabnik uporabnik)
        {
            
           
            using (var db= new Baza())
            {
                foreach (var item in db.uporabniki.ToList())
                {
                    if (item.Id== uporabnik.Id)
                    {
                        item.Ime = uporabnik.Ime;
                        item.priimek = uporabnik.priimek;
                        item.RojstniDan = uporabnik.RojstniDan;
                        item.KrajRojstva = uporabnik.KrajRojstva;
                        item.emso = uporabnik.emso;
                        item.starost = uporabnik.starost;
                        item.Naslov = uporabnik.Naslov;
                        item.Posta = uporabnik.Posta;
                        item.PostnaStevilka = uporabnik.PostnaStevilka;
                        item.Drzava = uporabnik.Drzava;
                        item.Email = uporabnik.Email;
                       
                        break;
                    }
                }
                db.SaveChanges();
            }

       

            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {

            //brisi iz baze
            id++;
            using (var db= new Baza())
            {
                
                foreach (var item in db.uporabniki)
                {
                    if (item.Id==id)
                    {
                        db.uporabniki.Remove(item);
                      
                        break;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Pregled()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pregled(Uporabnik uporabnik) //Tukaj se dodaja pa to lol pazi pri ostalih!!!
        {
            if (ModelState.IsValid)
            {
                
                using (var db= new Baza())
                {
                    db.uporabniki.Add(uporabnik);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View(uporabnik);
            }
            
            
        }

        [HttpGet]
        public IActionResult IzpisPregled(int id)
        {
            id++;
            Uporabnik uporabnik = new Uporabnik();
            using (var db= new Baza())
            {
                //db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Uporabniks', RESEED, 0)");
                foreach (var item in db.uporabniki.ToList())
                {
                    //4 , 1+1
                    
                    if (item.Id== id)
                    {
                        uporabnik = item;
                    }
                }


            }
            return View(uporabnik);
        }


        public IActionResult Registracija()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registracija(Uporabnik uporabnik)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Izpis", uporabnik);
            }
            return View(uporabnik);

        }






        [HttpGet]
        public IActionResult Izpis(Uporabnik uporabnik)
        {
            return View(uporabnik);
        }


      
      


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
