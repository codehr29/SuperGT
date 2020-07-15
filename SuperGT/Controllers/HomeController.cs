using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperGT.Models;
using SuperGT.Services;
using SuperGT.Views;

namespace SuperGT.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurant;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurant = restaurantData;
        }

        public IActionResult Index()
        {
            var model = _restaurant.GetAll();
            return View(model);

            //return Content("Hello from View");
        }

    }
}
