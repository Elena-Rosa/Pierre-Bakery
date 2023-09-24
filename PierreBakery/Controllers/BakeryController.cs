using Microsoft.AspNetCore.Mvc;
using PierreBakery.Models;
using System.Collections.Generic;

namespace PierreBakery.Controllers
{
  public class BakeryController : Controller
  {
     List<Vendor> allItems;
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      //List<Vendor> allItems = Vendor.GetAll();
      return View(allItems);
    }

    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create (string name, string description)
    {
      Vendor myVendor = new Vendor(name, description);
      allItems.Add(myVendor);
      return RedirectToAction("Index");
    }

    /*[HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }
    */
  
  }
}