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
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Nadia="Nadia";
            ViewBag.MeaningOfLife = 42;
            return View();
        }

        [HttpGet("click")]
        public IActionResult viewbagdoesntwork(){
            return View("Index");
        }

        // [HttpPost("newQuote")]
        // public IActionResult newQuote(string quote,string who){
        //     ViewBag.quote = quote;
        //     ViewBag.whosaiddat = who;
        //     return View("Result");
        // }

        [HttpGet("AllQuotes")]
        public IActionResult Result(){
            ViewBag.allQuote = QuoteLibrary.allQuote;
            return View("Result");
        }

        [HttpPost("newQuote")]
        public IActionResult newQuote(Quote quotefromform){
            QuoteLibrary.allQuote.Add(quotefromform);
            return RedirectToAction("Result");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
