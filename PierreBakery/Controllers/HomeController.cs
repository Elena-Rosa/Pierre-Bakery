using Microsoft.AspNetCore.Mvc;

namespace PierreBakery.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}