namespace Hotel.Application.Common.Models
{
    public class HotelSearchResponse
    {
        public Guid SearchId { get; set; }
        public HotelSearchRequest Request { get; set; }
        public List<HotelResult> HotelResults { get; set; }
        public int ResultCount => HotelResults.Count;
    }
}
