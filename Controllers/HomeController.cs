using dsd603Vm2025StudentVersion.Models;
using dsd603Vm2025StudentVersion.Services;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace dsd603Vm2025StudentVersion.Controllers
{
    public class HomeController(ILogger<HomeController> logger, ITextFileOperations textFileOperations, IDataSeeder dataSeeder) : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            logger.LogInformation("IndexAsync method invoked.");

            ViewBag.Welcome = "Welcome to the VMS";

            ViewBag.VisitorNew = new Visitors()
            {
                FirstName = "Howard",
                LastName = "The Barbarian"
            };

            await dataSeeder.SeedAsync();

            ViewData["Conditions"] = textFileOperations.LoadConditionsForAcceptanceText();

            return View();
        }

        public IActionResult Privacy()
        {
            logger.LogInformation("Privacy method invoked.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            logger.LogError("Error method invoked.");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
