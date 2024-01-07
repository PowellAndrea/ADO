using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ADO.Controllers
{
    public class HomeController : Controller
    {
        private AdventureWorks2019Entities db = new AdventureWorks2019Entities();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetNames()
        {
            List<GetNames_Result> nameList = new List<GetNames_Result>();

            foreach (var item in db.GetNames())
            {
               nameList.Add(item);
            }

            return View(nameList);
        }
    }
}