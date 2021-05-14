using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBApp.Models;

namespace DBApp.Controllers
{
    public class CartoonController : Controller
    {
        private CartoonContext cartoonContext = new CartoonContext();
        
        public ActionResult Index()
        {
            //eturn View(phoneContext.Cartoones.ToList());
            List<Cartoon> c = new List<Cartoon>
            {
                new Cartoon() {Id = 1, Studio = "Disnay", Name = "Маугли"}
            };

            return View(c);
        }

        public ActionResult AddCartoon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Cartoon phone)
        {
            cartoonContext.Cartoones.Add(phone);
            cartoonContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var deleted = cartoonContext.Cartoones.First(b => b.Id == id);
            cartoonContext.Cartoones.Remove(deleted);
            cartoonContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}