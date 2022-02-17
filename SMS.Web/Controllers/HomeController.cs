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
         
         Title = "About Us Page",
         Message = "Custom Message Entered Here:",
         Formed = new DateTime(1997, 12, 03),
         };
         return View(about);
      }
   }
}