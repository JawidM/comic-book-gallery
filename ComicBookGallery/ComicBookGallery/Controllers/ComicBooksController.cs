using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBook
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "Final Issue!";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slot",
                "Letters: Edgar Delgado"
            };  
            return View();
        }
    }
}