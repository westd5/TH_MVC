using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TalkingHeads.Models;
using System.Collections.Generic;

namespace TalkingHeads.Controllers
{
    public class ConcertController : Controller
    {
        private ConcertContext context { get; set; }

        public ConcertController(ConcertContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("List", "Concert");
        }

        [HttpGet]
        public IActionResult List()
        {
            List<Concert> concerts;
            concerts = context.Concerts.OrderBy(c => c.ConcertId).ToList();
            ViewBag.Concerts = concerts;
            return View(concerts);

        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Concert());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var concert = context.Concerts.Find(id);
            return View(concert);
        }

        [HttpPost]
        public IActionResult Edit(Concert concert)
        {
            if (ModelState.IsValid)
            {
                if (concert.ConcertId == 0)
                    context.Concerts.Add(concert);
                else
                    context.Concerts.Update(concert);
                context.SaveChanges();
                return RedirectToAction("List", "Concert");
            }
            else
            {
                ViewBag.Action = (concert.ConcertId == 0) ? "Add" : "Edit";
                return View(concert);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var concert = context.Concerts.Find(id);
            return View(concert);
        }

        [HttpPost]
        public IActionResult Delete(Concert concert)
        {
            context.Concerts.Remove(concert);
            context.SaveChanges();
            return RedirectToAction("List", "Concert");
        }
    }
}