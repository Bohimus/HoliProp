namespace HoliProp.Data.Entities;

public class Booking
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int PropertyId { get; set; }
    public Property? Property { get; set; }
}
