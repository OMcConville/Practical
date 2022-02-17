using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers
{

   public class HomeController : Controller
   {
      public IActionResult Index()
      {
         return Content("Web Development");
      }
      public IActionResult About()
      {
         // construct the view model
         var about = new AboutViewModel {
         Formed = new DateTime(2020, 01, 01)      
         };
         return View(about);
      }
   }
}