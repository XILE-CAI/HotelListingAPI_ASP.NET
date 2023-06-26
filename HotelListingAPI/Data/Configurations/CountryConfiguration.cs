using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
               new Country
               {
                   Id = 1,
                   Name = "Australia",
                   ShortName = "AU",
               },
               new Country
               {
                   Id = 2,
                   Name = "Thailand",
                   ShortName = "TH",
               },
               new Country
               {
                   Id = 3,
                   Name = "England",
                   ShortName = "EN",
               }
           );
        }
    }
}
