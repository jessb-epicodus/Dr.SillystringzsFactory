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
    public ActionResult Index() {
      ViewBag.Engineers = _db.Engineers
        .Include(engineer => engineer.JoinEntities)
        .ThenInclude(join => join.Machine)
        .ToList();
      return View(_db.Engineers.OrderBy(engineer => engineer.Company).ToList());
    }
    public ActionResult Create() {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer, int MachineId) {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id= engineer.EngineerId});
    }
    public ActionResult Edit(int id) {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }
    [HttpPost]
    public ActionResult Edit(Engineer engineer, int MachineId) {
      if (MachineId != 0) {
        _db.EngineerMachine.Add(new EngineerMachine() {EngineerId = engineer.EngineerId, MachineId = MachineId});
      }
      _db.Entry(engineer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id= engineer.EngineerId});
    }
    public ActionResult Delete(int id) {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      _db.Engineers.Remove(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id) {
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MakeModel");
      var thisEngineer = _db.Engineers
        .Include(engineer => engineer.JoinEntities)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }
    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int MachineId) {
      if (MachineId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() {EngineerId = engineer.EngineerId, MachineId = MachineId});
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new {id= engineer.EngineerId});
    }
    [HttpPost, ActionName("DeleteMachine")]
    public ActionResult DeleteConfirmed(int joinId, EngineerMachine engineermachine) {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
      _db.EngineerMachine.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}