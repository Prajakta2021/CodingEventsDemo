using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
        List<string> Events = new List<string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            /* List<string> Events = new List<string>();
             Events.Add("Code With Pride");
             Events.Add("Apple WWDC");
             Events.Add("Strange Loop");*/

            ViewBag.events = Events;

            return View();
        }

        [HttpGet]
        public IActionResult Addevent()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/addevent")]
        public IActionResult NewEvent(string name)
        {
            Events.Add(name);
            return Redirect("/Events");
        }
    }
}

