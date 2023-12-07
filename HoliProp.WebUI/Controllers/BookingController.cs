using HoliProp.Logic.Services;
using HoliProp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoliProp.WebUI.Controllers;

public class BookingController : Controller
{
    private readonly IPropertyService _propertyService;

    public BookingController(IPropertyService propertyService)
    {
        _propertyService = propertyService;
    }

    [HttpGet]
    public IActionResult Search(DateTime? from, DateTime? to)
    {
        if (from is null || to is null)
        {
           return View(new BookingSearchViewModel { From = DateTime.Now, To = DateTime.Now.AddDays(3) });
        }

        return View(new BookingSearchViewModel { Properties = _propertyService.GetProperties(from.Value, to.Value), From = from, To = to });
    }

    [HttpPost]
    public IActionResult Search(DateTime from, DateTime to)
    {
        var properties = _propertyService.GetProperties(from, to);

        return View(new BookingSearchViewModel { Properties = properties, From = from, To = to });
    }
}
