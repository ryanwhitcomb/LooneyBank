using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LooneyBank.Core;


namespace LooneyBankWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult BankTool()
        {

            Bank firstBank = new Bank(1);
            ViewBag.BankName = firstBank.bankName;
            return View();
        }

        
    }
}
