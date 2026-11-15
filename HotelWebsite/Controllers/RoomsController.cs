using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebsite.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Rooms
        public ActionResult Index()
        {
            return View();
        }
        [Route("~/business-suite", Name = "businesssuite")]
        public ActionResult BusinessSuite()
        {
            return View();
        }
        [Route("~/deluxe-room", Name = "deluxeroomplus")]
        public ActionResult DeluxeRoomPlus()
        {
            return View();
        }
        [Route("~/executive-suite", Name = "executivesuite")]
        public ActionResult ExecutiveSuite()
        {
            return View();
        }
        [Route("~/royal-suite", Name = "roylesuite")]
        public ActionResult RoyalSuite()
        {
            return View();
        }
        [Route("~/standard-room", Name = "standardroom")]
        public ActionResult StandardRoom()
        {
            return View();
        }
    }
}