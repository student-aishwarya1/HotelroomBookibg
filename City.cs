using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; } 
        public string City_Name  { get; set; }

    }
}
