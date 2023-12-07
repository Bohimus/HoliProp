using HoliProp.Logic.Services;
using HoliProp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoliProp.WebUI.Controllers;

public class PropertiesController : Controller
{
    private readonly IPropertyService _propertyService;

    public PropertiesController(IPropertyService propertyService)
    {
        _propertyService = propertyService;
    }

    public IActionResult All()
    {
        var properties = _propertyService.GetProperties();
        return View(properties);
    }

    [HttpGet]
    public IActionResult Details(int id, DateTime? from, DateTime? to, string returnUrl)
    {
        var property = _propertyService.GetProperty(id);
        var available  = _propertyService.GetFirstAvailableDates(id, 3);

        var viewModel = new PropertyDetailsViewModel()
        {
            Property = property,
            From = from ?? available?.From,
            To = to ?? available?.To,
            ReturnUrl = returnUrl
        };

        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Details(int id, DateTime from, DateTime to, string returnUrl)
    {
        _propertyService.BookProperty(id, from, to);

        var property = _propertyService.GetProperty(id);
        var available = _propertyService.GetFirstAvailableDates(id, 3);

        var viewModel = new PropertyDetailsViewModel()
        {
            Property = property,
            From = available?.From,
            To = available?.To,
            ReturnUrl = returnUrl
        };

        return View(viewModel);
    }
}
