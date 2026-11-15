using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebsite.Controllers
{
    public class GalleryController : Controller
    {
        [Route("~/hotel-gallery", Name = "galleryhotelnaran")]
        // GET: Gallery
        public ActionResult Index()
        {
            return View();
        }

     
    }
}