using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public int Hotel_Id { get; set; }
        public string C_Name { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }

    }
}
