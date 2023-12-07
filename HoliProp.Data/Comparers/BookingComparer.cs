using HoliProp.Data.Entities;

namespace HoliProp.Data.Comparers;

public class BookingComparer : IEqualityComparer<Booking>
{
    public bool Equals(Booking x, Booking y)
    {
        if (ReferenceEquals(x, y)) return true;

        if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
            return false;

        return x.Date.Day == y.Date.Day && x.Date.Month == y.Date.Month && x.Date.Year == y.Date.Year;
    }

    public int GetHashCode(Booking booking)
    {
        if (ReferenceEquals(booking, null)) return 0;

        int dayHash = booking.Date.Day.GetHashCode();
        int monthHash = booking.Date.Month.GetHashCode();
        int yearHash = booking.Date.Year.GetHashCode();

        return dayHash ^ monthHash ^ yearHash;
    }
}
