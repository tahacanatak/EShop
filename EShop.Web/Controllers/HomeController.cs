using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EShop.Web.Models;
using EShop.ApplicationCore.Interfaces;
using EShop.Web.Interfaces;

namespace EShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeIndexViewModelService _homeIndexViewModelService;

        public HomeController(IHomeIndexViewModelService homeIndexViewModelService)
        {
            _homeIndexViewModelService = homeIndexViewModelService;
        }

        public IActionResult Index()
        {
            return View(_homeIndexViewModelService.GetIndexViewModel());
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
