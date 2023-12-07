using HoliProp.Data.Contexts;
using HoliProp.Data.Entities;

namespace HoliProp.Data.Initializers;

public class AppDbContextInitializer
{
    private readonly AppDbContext _appDbContext;

    public AppDbContextInitializer(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void Init()
    {
        _appDbContext.Properties.AddRange(Properties);
        _appDbContext.SaveChanges();
    }

    public List<Property> Properties { get; } = new ()
    {
        new()
        {
            Id = 1,
            Name = "Rose Cottage",
            Blurb = "Beautiful cottage on the Cornwall coast",
            Location = "Cornwall",
            Bedrooms = 3,
            CostPerNight = 350,
            ImageAddresses = new()
            {
                new() { PropertyId = 1, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" },
                new() { PropertyId = 1, Address = "https://img.freepik.com/premium-photo/model-house-with-red-door-red-door_14117-6166.jpg" },
                new() { PropertyId = 1, Address = "https://img.freepik.com/premium-photo/model-house-with-red-door-red-door_14117-6166.jpg" }
            },
            Description = "Para ir toca capa pito doce me ni ha. Ama haciendo calavera voz estupido penumbra esa. Eso inspiraban puntiaguda exigencias mil nos extremados. Carinosos americano envidioso mil van pensarian. Levantaban compadecia pagarselos aun hoy mal. Blancas asistir oyo dar los decirlo recibio. Tal tan sexo eso sola para nota.",
            Bookings = new()
            {
                //new()
                //{
                //    Date = DateTime.Now,
                //    PropertyId = 1,
                //}
            }
		},
        new()
        {
            Id = 2,
            Name = "Safron House",
            Blurb = "Stately home on the Devon moores",
            Location = "Devon",
            Bedrooms = 7,
            CostPerNight = 730,
            ImageAddresses = new()
            {
                new() { PropertyId = 2, Address = "https://img.freepik.com/premium-photo/model-house-with-red-door-red-door_14117-6166.jpg" },
                new() { PropertyId = 2, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" },
                new() { PropertyId = 2, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" }
            },
			Description = "Para ir toca capa pito doce me ni ha. Ama haciendo calavera voz estupido penumbra esa. Eso inspiraban puntiaguda exigencias mil nos extremados. Carinosos americano envidioso mil van pensarian. Levantaban compadecia pagarselos aun hoy mal. Blancas asistir oyo dar los decirlo recibio. Tal tan sexo eso sola para nota.",
			Bookings = new()
			{
				//new()
				//{
				//	Date = DateTime.Now,
				//	PropertyId = 2,
				//}
			}
		},
        new()
        {
            Id = 3,
            Name = "Marble House",
            Blurb = "Lovely home on the coast",
            Location = "Meizen",
            Bedrooms = 3,
            CostPerNight = 970,
            ImageAddresses = new()
            {
                new() { PropertyId = 3, Address = "https://img.freepik.com/premium-photo/house-model-isolated-black-background_771335-30725.jpg" },
                new() { PropertyId = 3, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" },
                new() { PropertyId = 3, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" }
            },
			Description = "Para ir toca capa pito doce me ni ha. Ama haciendo calavera voz estupido penumbra esa. Eso inspiraban puntiaguda exigencias mil nos extremados. Carinosos americano envidioso mil van pensarian. Levantaban compadecia pagarselos aun hoy mal. Blancas asistir oyo dar los decirlo recibio. Tal tan sexo eso sola para nota.",
			Bookings = new()
			{
				new()
				{
					Date = DateTime.Now,
					PropertyId = 3,
				}
			}
		},
        new()
        {
            Id = 4,
            Name = "Wood House",
            Blurb = "Beautiful house near lake",
            Location = "Garbie",
            Bedrooms = 4,
            CostPerNight = 600,
            ImageAddresses = new()
            {
                new() { PropertyId = 4, Address = "https://img.freepik.com/premium-photo/house-with-red-door-black-roof_771335-48643.jpg" },
                new() { PropertyId = 4, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" },
                new() { PropertyId = 4, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" }
            },
			Description = "Para ir toca capa pito doce me ni ha. Ama haciendo calavera voz estupido penumbra esa. Eso inspiraban puntiaguda exigencias mil nos extremados. Carinosos americano envidioso mil van pensarian. Levantaban compadecia pagarselos aun hoy mal. Blancas asistir oyo dar los decirlo recibio. Tal tan sexo eso sola para nota.",
			Bookings = new()
			{
				new()
				{
					Date = DateTime.Now,
					PropertyId = 4,
				}
			}
		},
        new()
        {
            Id = 5,
            Name = "Stone House",
            Blurb = "Awesome country home in the forest",
            Location = "Bredley",
            Bedrooms = 6,
            CostPerNight = 1220,
            ImageAddresses = new()
            {
                new() { PropertyId = 5, Address = "https://img.freepik.com/premium-photo/small-model-house-with-red-roof-red-door_14117-5647.jpg" },
                new() { PropertyId = 5, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" },
                new() { PropertyId = 5, Address = "https://img.freepik.com/free-photo/blue-house-with-blue-roof-sky-background_1340-25953.jpg" }
            },
			Description = "Para ir toca capa pito doce me ni ha. Ama haciendo calavera voz estupido penumbra esa. Eso inspiraban puntiaguda exigencias mil nos extremados. Carinosos americano envidioso mil van pensarian. Levantaban compadecia pagarselos aun hoy mal. Blancas asistir oyo dar los decirlo recibio. Tal tan sexo eso sola para nota.",
			Bookings = new()
			{
				new()
				{
					Date = DateTime.Now,
					PropertyId = 5,
				}
			}
		}
    };
}
