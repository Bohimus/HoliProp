using HoliProp.Data.Comparers;
using HoliProp.Data.Contexts;
using HoliProp.Data.Entities;

namespace HoliProp.Logic.Services;

public class PropertyService : IPropertyService
{
    private readonly AppDbContext _appDbContext;

    public PropertyService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void BookProperty(int id, DateTime from, DateTime to)
    {
        var property = _appDbContext.Properties.SingleOrDefault(p => p.Id == id);

        if (property == null) return;
        if (from <= DateTime.Now.AddDays(-1)) return;
        if (from > to) return;

        var temp = from;
        var newBookings = new List<Booking>();
        while (true)
        {
            if (temp > to) break;

            newBookings.Add(new Booking { Date = temp, PropertyId = property.Id, Property = property });

            temp = temp.AddDays(1);
        }

        if (property.Bookings.Intersect(newBookings, new BookingComparer()).Count() != 0) return;

        property.Bookings.AddRange(newBookings);

        _appDbContext.SaveChanges();
    }

    public (DateTime, DateTime)? GetFirstAvailableDates(int id, int days)
    {
        if (days < 1) return null;

        var property = _appDbContext.Properties.SingleOrDefault(p => p.Id == id);

        if (property is null) return null;

        var now = DateTime.Now;
        var available = now;

        while (true)
        {
            if ( ! property.Bookings.Contains(new Booking { Date = available}, new BookingComparer())) break;

            available = available.AddDays(1);
        }

        var availableTill = available;
        for (int i = 0; i < days - 1; i++)
        {
            if (property.Bookings.Contains(new Booking { Date = availableTill.AddDays(1) }, new BookingComparer())) break;

            availableTill = availableTill.AddDays(1);
        }

        return (available, availableTill);
    }

    public IEnumerable<Property> GetProperties()
    {
        return _appDbContext.Properties;
    }

    public Property? GetProperty(int id)
    {
        return _appDbContext.Properties.SingleOrDefault(p => p.Id == id);
    }

    public IEnumerable<Property> GetTopProperties(int count)
    {
        return _appDbContext.Properties.Reverse().Take(count);
    }

    public IEnumerable<Property> GetProperties(DateTime from, DateTime to)
    {
        if (from <= DateTime.Now.AddDays(-1)) return Enumerable.Empty<Property>();
        if (from > to) return Enumerable.Empty<Property>();

        var dates = new List<Booking>();
        var temp = from;
        while (true)
        {
            if (temp > to) break;

            dates.Add(new Booking { Date = temp });

            temp = temp.AddDays(1);
        }

        var properties = new List<Property>();

        foreach (var property in _appDbContext.Properties)
        {
            if (property.Bookings.Intersect(dates, new BookingComparer()).Count() == 0)
            {
                properties.Add(property);
            }
        }

        return properties;
    }
}
