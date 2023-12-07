using HoliProp.Data.Entities;

namespace HoliProp.WebUI.Models;

public class BookingSearchViewModel
{
    public IEnumerable<Property> Properties { get; set; } = new List<Property>();
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
}
