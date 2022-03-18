using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Factory.Models;

namespace Factory.Controllers {
  public class MachinesController : Controller {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db) {
      _db = db;
    }
    public ActionResult Create() {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Company");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine, int EngineerId) {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      if (EngineerId != 0) {
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details");
    }
  }
}