namespace HoliProp.Data.Entities;

public class Property
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Blurb { get; set; }
    public string? Location { get; set; }
    public int Bedrooms { get; set; }
    public decimal CostPerNight { get; set; }
    public List<ImageAddress> ImageAddresses { get; set; } = new List<ImageAddress>();
	public string? Description { get; set; }
    public List<Booking> Bookings { get; set; } = new List<Booking>();
}
