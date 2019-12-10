using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
  public class WeddingController : Controller
  {
    private MyContext DbContext;
    public WeddingController(MyContext context)
    {
      DbContext = context;
    }

    [HttpGet("weddings/all")]
    public IActionResult All()
    {
      List<Wedding> allWeddings = DbContext.Weddings.ToList();
      return View(allWeddings);
    }

    [HttpGet("weddings/new")]
    public IActionResult New()
    {
      return View();
    }

    [HttpPost("weddings/create")]
    public IActionResult Create(Wedding newWedding)
    {
      if (ModelState.IsValid)
      {
        var userfromDb = DbContext.Users.FirstOrDefault(user => user.UserId == HttpContext.Session.GetInt32("userId"));
        newWedding.Creator = userfromDb;
        newWedding.UserId = userfromDb.UserId;
        DbContext.Weddings.Add(newWedding);
        DbContext.SaveChanges();
        return RedirectToAction("All");
      }
      else
      {
        return View("New");
      }
    }

  }
}
