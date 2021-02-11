using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment4FoodApp.Models;

namespace Assignment4FoodApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("List")]
        public IActionResult RestaurantList()
        {
            List<string> restList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restList.Add(string.Format("#{0}: {1} - {2} ({3}, {4}, {5})", r.RestRanking, r.RestName, r.FavDish, r.Address, r.RestPhone, r.WebLink));
            }

            return View(restList);
        }


        [HttpGet]
        public IActionResult RestSubmission()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RestSubmission(ApplicationResponse applicationResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(applicationResponse);
                return View("Confirmation", applicationResponse);
            }
            else
            {
                return View();
            }

        }

        public IActionResult RestDisplay()
        {
            return View(TempStorage.Applications);
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
