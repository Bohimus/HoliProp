using HoliProp.Data.Entities;

namespace HoliProp.Logic.Services
{
    public interface IPropertyService
    {
        IEnumerable<Property> GetProperties();
        IEnumerable<Property> GetTopProperties(int count);
        IEnumerable<Property> GetProperties(DateTime from, DateTime to);
        Property? GetProperty(int id);
        void BookProperty(int id, DateTime from, DateTime to);
        (DateTime From, DateTime To)? GetFirstAvailableDates(int id, int days);
    }
}