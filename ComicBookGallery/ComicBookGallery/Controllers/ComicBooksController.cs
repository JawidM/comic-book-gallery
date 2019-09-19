using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "Final Issue!",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Viktor Ola", Role = "Inks" },
                    new Artist() { Name = "Edgar Del", Role = "Colors" }
                }
            };
            return View(comicBook);
        }
    }
}