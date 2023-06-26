using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Grand Hotel",
                   Address = "KingsWillan Street",
                   CountryId = 3,
                   Rating = 4.6
               },
                new Hotel
                {
                    Id = 2,
                    Name = "Standford Hotel",
                    Address = "Glenelg Beach",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Griffed Hotel",
                    Address = "North Terrance",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Internation Thai Hotel",
                    Address = "Bnagkok road",
                    CountryId = 2,
                    Rating = 4.6
                }
           );
        }
    }
}
