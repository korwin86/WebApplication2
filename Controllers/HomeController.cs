using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();
        public ActionResult Index()
        {
            //извлекаем данные из таблицы Phones
            IEnumerable<Phone> phones = phoneContext.Phones;
            //записываем phones в динамическое свойство ViewBag
            ViewBag.Phones = phones;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = DateTime.Now;

            phoneContext.Purchases.Add(purchase);
            phoneContext.SaveChanges();

            return $"Уважаемый {purchase.FIO} вам пиздец!";
        }

        [HttpGet]
        public ActionResult Purchases()
        {
            IEnumerable<Purchase> purchase = phoneContext.Purchases;
            ViewBag.Purchases = purchase;

            return View(phoneContext.Phones);
        }
    }
}