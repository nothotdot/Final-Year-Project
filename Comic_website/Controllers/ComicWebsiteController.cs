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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic website controller");
            
            }
        }
    }