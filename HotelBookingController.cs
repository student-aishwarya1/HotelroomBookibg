using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelBooking.Controllers
{
    public class HotelBookingController : Controller
    {
        private readonly HotelContext _context;
        public HotelBookingController(HotelContext Context)
        {
            _context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new Register()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Address = model.Address,
                    Pincode = model.Pincode,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword,
                };
                _context.Registers.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                return View(model);
            }

        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, int password)
        {
            var user = _context.Registers.FirstOrDefault(u => u.Email == email);
            if (user != null && (password == user.Password))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        //public IActionResult City()
        //{
        //    return View();

        //}

        //HotelDetails
        [HttpGet]
        public IActionResult HotelDetail(string location, string roomType)
        {
            if(location  == null && roomType == null)
            {
                var pro = _context.HotelDetail.ToList();
                return new JsonResult(pro);
            }
            var filteredHotels = _context.HotelDetail.Where(hotel => hotel.Location == location && hotel.Bed_Type == roomType).ToList();
            return new JsonResult(filteredHotels);
        }


        public IActionResult data(HotelDetails model, IFormFile Image)
        {
            if (Image != null && Image.Length > 0)
            {
                using (MemoryStream str = new MemoryStream())
                {
                    Image.CopyTo(str);
                    model.Image = str.ToArray();
                }

            }
            _context.HotelDetail.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BookNow(int id)
        {
            var Book = _context.HotelDetail.Where(x => x.Id == id).ToList();
            return View(Book);
        }

        public IActionResult Booking()
        {

            return View();
        }
        [HttpPost]
         public IActionResult SubmitBooking(Booking formData)
    {
        if (ModelState.IsValid)
        {
            var customerBooking = new Booking
            {
                C_Name = formData.C_Name,
                Contact = formData.Contact,
                Email = formData.Email,
                Address = formData.Address,
                checkInDate = formData.checkInDate,
                checkInTime = formData.checkInTime,
                checkOutDate = formData.checkOutDate,
                checkOutTime = formData.checkOutTime,
                roomType = formData.roomType,
                person = formData.person,
                 price = formData.price = formData.price

            };
            _context.Bookings.Add(customerBooking);
            _context.SaveChanges();
            return Json(new { success = true, message = "Booking information submitted successfully." });
        }
        return Json(new { success = false, message = "Invalid data. Please check the form fields." });
    }

        //public IActionResult GenerateBill(int bookingId)
        //{
        //    return View();
        //}
        public IActionResult GenerateBill()
        {
            return View();
        }


    }

}

