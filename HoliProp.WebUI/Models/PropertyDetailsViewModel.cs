using HoliProp.Data.Entities;

namespace HoliProp.WebUI.Models;

public class PropertyDetailsViewModel
{
    public Property? Property { get; set; }
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public string ReturnUrl { get; set; }
}
