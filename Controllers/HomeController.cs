using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Csharp_DojoSurvey.Models;

namespace Csharp_DojoSurvey.Controllers
{

    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult Result(Survey MySurvey)
        {
            // ViewBag.Name = Name;
            // ViewBag.Locations = Locations;
            // ViewBag.Languages= Languages;
            // ViewBag.Comments = Comments;
            return View(MySurvey);
        }
    }
}

