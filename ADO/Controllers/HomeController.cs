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

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetNames_Result getNames_Result = db.GetNames_Result.Find(id);
            if (getNames_Result == null)
            {
                return HttpNotFound();
            }
            return View(getNames_Result);
        }


    }
}