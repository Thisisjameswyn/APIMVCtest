using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
  public class TravelAPIContext : DbContext
  {
    public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
        : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
        .HasData(
          new Destination { DestinationId = 1, CountryName = "Canada", CityName = "Vancouver", Review = "I love this destination. There was lots of fun things to do. The landmarks alone are worth the travel!", RateReview = 5 },
          new Destination { DestinationId = 2, CountryName = "Mexico", CityName = "Mexico City", Review = "Everything was so colorful and the mural art was amazing. Definitely worth the travel to see some of the Aztec ancient sites!", RateReview = 4 },
          new Destination { DestinationId = 3, CountryName = "Italy", CityName = "Venezuela", Review = "The food is amazing and the ancient buildings and churches are beautiful! There is also lots of art and sculptures to be seen. Make sure you bring a few pairs of walking shoes!", RateReview = 5 },
          new Destination { DestinationId = 4, CountryName = "Thailand", CityName = "Song Khon", Review = "The weather was nice and warm. The food not only was cheap but also really tasty. Its worth spending money on a good hotel!", RateReview = 4 },
          new Destination { DestinationId = 5, CountryName = "New Zeland", CityName = "Auckland", Review = "You have to visit for yourself. The food was really good in general. The valleys were breathtaking...", RateReview = 5 }
        );
    }
    public DbSet<Destination> Destinations { get; set; }
  }
}
