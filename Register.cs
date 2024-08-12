using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Pincode { get; set; }
        public int Password { get; set; }
        public int ConfirmPassword { get; set; }
    }
}
