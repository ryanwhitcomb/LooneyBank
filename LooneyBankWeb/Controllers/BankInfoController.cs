using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LooneyBankWeb.Controllers
{
    public class BankInfoController : Controller
    {
        //
        // GET: /BankInfo/

        public ActionResult ShowBankInfo(string name)
        {
            return View();
        }

    }
}
