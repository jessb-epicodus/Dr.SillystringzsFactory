using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers {
  public class HomeController : Controller {
    [HttpGet("/")]
    public ActionResult Index() {
      //_db.Engineers.OrderBy(engineer => engineer.Company).ToList()
      //_db.Machines.OrderBy(machine => machine.Status).ToList()
      return View();
    }
  }
}