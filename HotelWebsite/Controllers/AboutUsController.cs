using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebsite.Controllers
{
    public class AboutUsController : Controller
    {
       [Route("~/about-hotel-home-naran", Name = "abouthotelhomenaran")]
        // GET: AboutUs
        public ActionResult Index()
        {
            return View();
        }
    }
}