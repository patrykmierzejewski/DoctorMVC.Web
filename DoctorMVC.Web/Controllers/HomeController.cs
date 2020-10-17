using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoctorMVC.Web.Models;
using DoctorMVC.Application.Services;
using DoctorMVC.Application.Interfaces;

namespace DoctorMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       /* private readonly IItemService _itermService;*/

        public HomeController(ILogger<HomeController> logger/*, ItemService service*/)
        {
            _logger = logger;
            /*_service = service;*/
        }

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //?id=2&name=nazwa
        [Route("Items/All")]
        public IActionResult ViewListOfItems(int id, string name)
        {
            ViewBag.name = 2;

            List<Item> items = new List<Item>();
            items.Add(new Item() { Id = 1, Name = "Apple", TypeName = "Grocery" });
            items.Add(new Item() { Id = 2, Name = "Strawberry", TypeName = "Grocery" });
            items.Add(new Item() { Id = 3, Name = "Carrot", TypeName = "Grocery" });

            return View(items);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
