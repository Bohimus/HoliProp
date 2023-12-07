namespace HoliProp.Data.Entities;

public class ImageAddress
{
    public int Id { get; set; }
    public int PropertyId { get; set; }
    public Property? Property { get; set; }
    public string? Address { get; set; }
}