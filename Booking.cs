using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Booking
    {
        [Key]
        public int Id {  get; set; }
        public string C_Name { get; set; }
        public long Contact { get; set;}
        public string Email { get; set;} 
        public string Address {  get; set;}
        public string checkInDate {  get; set;}
        public string checkInTime { get; set; }

        public string checkOutDate { get; set;}
        public string checkOutTime { get; set; }
        public string roomType {  get; set;}
        public string person { get; set;} 
        public Double price { get; set;}


    }
}
