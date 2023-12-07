using HoliProp.Logic.Services;
using HoliProp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HoliProp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IPropertyService propertyService, ILogger<HomeController> logger)
        {
            _propertyService = propertyService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_propertyService.GetTopProperties(2));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}