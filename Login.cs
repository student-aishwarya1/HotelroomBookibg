using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public int Passward { get; set; }
    }
}
