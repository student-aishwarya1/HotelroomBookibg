using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class HotelDetails
    {
        [Key]
        public int Id { get; set; }
        public string Hotel_Name { get; set; }
        public string Bed_Type { get; set; }
        public string Location { get; set; }
        public String Price { get; set; }
        public byte[] Image { get; set; }

        public int CityId {  get; set; }
        [ForeignKey("CityId")]
        public City City { get; set;}

    }
}
