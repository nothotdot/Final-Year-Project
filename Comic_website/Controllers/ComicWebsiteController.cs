using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_website.Controllers
{
    public class ComicWebsiteController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.NewsTitle = "Court Wordicts on Mushaeaf";
            ViewBag.IssueDate = "19 December 2019";
            ViewBag.Descryption = "<p>Court wordect</p>";
            ViewBag.NewsInfo = new string[]
        {
              "Reporter : Hamza",
              "Source : CNN",
              "Other : Fox"
        };
            return View(); 
        }
            }
        }
    