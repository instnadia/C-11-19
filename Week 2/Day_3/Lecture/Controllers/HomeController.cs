using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lecture.Models;

namespace Lecture.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context){
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Trail> allTrails = dbContext.Trails.ToList();
            return View(allTrails);
        }

        [HttpGet("trail/{trailId}")]
        public IActionResult showOneTrail(int trailId){
            Trail oneTrail = dbContext.Trails.FirstOrDefault(trail => trail.TrailId==trailId);
            return View(oneTrail);
        }

        [HttpGet("Home/New")]
        public IActionResult NewTrail(){
            return View();
        }

        [HttpPost("Home/New")]
        public IActionResult createTrail(Trail newTrail){
            if(ModelState.IsValid){
                dbContext.Add(newTrail);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("NewTrail");
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
