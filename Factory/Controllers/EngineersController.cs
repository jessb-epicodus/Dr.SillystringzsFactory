using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Factory.Models;

namespace Factory.Controllers {
  public class EngineersController : Controller {
    private readonly FactoryContext _db;
    public EngineersController(FactoryContext db) {
      _db = db;
    }
    public ActionResult Create() {
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Make", "Model");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer, int MachineId) {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      if (MachineId != 0) {
        _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, EngineerId = engineer.EngineerId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details");
    }
  }
}