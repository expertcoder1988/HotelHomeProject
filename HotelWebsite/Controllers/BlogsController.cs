using HotelWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebsite.Controllers
{
    public class BlogsController : Controller
    {
        HotelDBEntities2 db = new HotelDBEntities2();

        [Route("~/blog-hotelhome-naran", Name = "bloghotelnaran")]
        // GET: Blogs
        public ActionResult Index()
        {
            var lst = (from c in db.Posts select c).OrderByDescending(c => c.PublishedDate).ToList();
            ViewBag.blogs = lst;

            return View();
        }

        [Route("~/post/{postId:int}", Name = "postDetailRoute")]
        public ActionResult Post(int PostId)
        {
            var blog = (from c in db.Posts where c.PostId == PostId select c).ToList();
            TempData["blog"] = blog;

            return View();
        }

        public ActionResult Image(string img)
        {
            var image = "C:\\inetpub\\wwwroot\\Hotel Home\\uploads\\post\\" + img;
            //string path = image.Path; // could be any absolute path anywhere on your server, for example c:\foo\bar.jpg
            string contentType = "image/jpg"; // image.ContentType; // for example image/jpg
            return File(image, contentType);
        }
        public List<Post> GetAllBlogs()
        {
            var lst = (from c in db.Posts
                       where c.IsPublished == true
                       select c).OrderByDescending(c => c.PublishedDate).ToList();
            return lst;

        }
    }
}