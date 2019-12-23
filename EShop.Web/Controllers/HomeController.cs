using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EShop.Web.Models;
using EShop.ApplicationCore.Interfaces;
using EShop.Web.Interfaces;
using Microsoft.AspNetCore.Http;

namespace EShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeIndexViewModelService _homeIndexViewModelService;

        public HomeController(IHomeIndexViewModelService homeIndexViewModelService)
        {
            _homeIndexViewModelService = homeIndexViewModelService;
        }

        public IActionResult Index(int? cid, int? p)
        {
            return View(_homeIndexViewModelService.GetHomeIndexViewModel(cid, p ?? 1, Constants.ITEMS_PER_PAGE)); // p yi gir nullsa 1 gir
        }

        public IActionResult Privacy([FromServices] IBasketService basketService)
        {
            basketService.AddItemToBasket(1, "kola", 3.5m, "", 3);
            ViewBag.items = basketService.BasketItems;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
