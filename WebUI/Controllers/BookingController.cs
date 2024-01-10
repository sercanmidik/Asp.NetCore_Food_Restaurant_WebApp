using BusinessLayer.Abstract;
using DtoLayer.BookingDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookService _bookService;

        public BookingController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateBooking(CreateBookingDto createBooking)
        {
            Book book = new Book()
            {
                DateTime = createBooking.DateTime,
                Email = createBooking.Email,
                Name = createBooking.Name,
                PersonCount = createBooking.PersonCount,
                SpecialRequest = createBooking.SpecialRequest,
                Status = "Rezervasyon Alındı",

            };
            _bookService.BusinessInsert(book);
            return RedirectToAction("Index", "Default");
        }
    }
}
