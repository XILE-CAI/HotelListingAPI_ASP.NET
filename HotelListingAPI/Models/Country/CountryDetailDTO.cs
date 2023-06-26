using HotelListingAPI.Models.Hotel;

namespace HotelListingAPI.Models.Country
{
    public class CountryDetailDTO : BaseCountryDTO
    {
        public int Id { get; set; }

        public IList<HotelDTO> Hotels { get; set; }
    }
}
