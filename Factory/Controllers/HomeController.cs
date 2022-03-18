using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Factory.Models;

namespace Factory.Controllers {
  public class HomeController : Controller {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db) {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index() {
      ViewBag.Engineers = _db.Engineers.ToList();
      ViewBag.Machines = _db.Machines.ToList();
      _db.Engineers.OrderBy(engineer => engineer.Company).ToList();
      _db.Machines.OrderBy(machine => machine.Make).ToList();
      return View();
    }
  }
}