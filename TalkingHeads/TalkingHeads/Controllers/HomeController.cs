using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalkingHeads.Models;

namespace TalkingHeads.Controllers
{
    public class HomeController : Controller
    {
        private ConcertContext context { get; set; }

        public HomeController(ConcertContext ctx)
        {
            context = ctx;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [Route("AboutTH")]
        public IActionResult AboutTH()
        {
            return View("AboutTH");
        }

        [Route("AboutMe")]
        public IActionResult AboutMe()
        {
            return View("AboutMe");
        }

        [Route("OtherResources")]
        public IActionResult OtherResources()
        {
            return View("OtherResources");
        }
    }
}