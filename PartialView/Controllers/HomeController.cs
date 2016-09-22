using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        List<string> testList;

        public HomeController()
        {
            testList = new List<string>()
            {
                "asd1",
                "asd2",
                "asd3",
                "asd4",
                "asd5"
            };
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult TestList()
        {
            return PartialView(testList);
        }
    }
}