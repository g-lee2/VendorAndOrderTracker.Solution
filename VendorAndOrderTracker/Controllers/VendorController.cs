using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName, string description)
    {
      Vendor aVendor = new Vendor(vendorName, description);
      return RedirectToAction("Index");
    }
  }
}
