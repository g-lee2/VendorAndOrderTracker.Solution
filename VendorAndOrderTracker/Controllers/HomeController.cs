using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Vendor starterVendor = new Vendor("London Pastry", "New Pastry Vendor");
      return View(starterVendor);
    }
    [HttpGet("/vendor/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}
