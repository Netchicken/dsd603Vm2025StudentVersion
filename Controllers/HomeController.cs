using dsd603Vm2025StudentVersion.Models;
using dsd603Vm2025StudentVersion.Services;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace dsd603Vm2025StudentVersion.Controllers
{
    public class HomeController(ILogger<HomeController> logger, ITextFileOperations textFileOperations) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Welcome = "Welcome to the VMS";


            ViewBag.VisitorNew = new Visitors()
            {
                FirstName = "Howard",
                LastName = "The Barbarian"
            };



            ViewData["Conditions"] = textFileOperations.LoadConditionsForAcceptanceText();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
