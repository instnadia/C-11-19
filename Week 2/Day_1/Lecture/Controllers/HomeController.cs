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
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Home/Registration")]
        public IActionResult Registration(User newUser){
            if(ModelState.IsValid){
                string query = $"INSERT INTO users (fName, lName, email, password) VALUES ('{newUser.fName}', '{newUser.lName}', '{newUser.email}','{newUser.password}')";
                DbConnector.Execute(query);
                return RedirectToAction("Success");
            }else{
                return View("Index");
            }
        }
        [HttpGet("success")]
        public IActionResult Success(){
            List<Dictionary<string, object>> allUsers = DbConnector.Query("SELECT * FROM users");
            return View(allUsers);
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
