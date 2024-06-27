using EventEase.Data;
using EventEase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EventEase.Controllers
{
    public class HomeController : Controller
    {
        private readonly EventEaseContext _eventEaseContext;

        public HomeController(EventEaseContext eventEaseContext)
        {
            _eventEaseContext = eventEaseContext;
        }

        public IActionResult Index()
        {
            return View(model: _eventEaseContext.Events.ToList());
        }
        public IActionResult AddEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEvent(Event _new)
        {
            _eventEaseContext.Events.Add(_new);
            _eventEaseContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
