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
    }
}