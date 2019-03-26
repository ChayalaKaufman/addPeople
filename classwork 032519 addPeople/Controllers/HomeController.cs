using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using classwork_032519_addPeople.Models;

namespace classwork_032519_addPeople.Controllers
{
    public class HomeController : Controller
    {
        Manager mgr = new Manager(Properties.Settings.Default.ConStr);

        public ActionResult Index()
        {
            return View(mgr.GetPeople());
        }

        public ActionResult AddPeople()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(List<Person> ppl)
        {
            mgr.Add(ppl);
            return Redirect("/");
        }
    }
}