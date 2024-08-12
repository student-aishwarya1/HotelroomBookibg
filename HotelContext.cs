using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace HotelBooking.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options ) : base(options) { }
        public DbContextOptions<HotelContext> Options { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<HotelDetails> HotelDetail { get; set; }
    }
}
