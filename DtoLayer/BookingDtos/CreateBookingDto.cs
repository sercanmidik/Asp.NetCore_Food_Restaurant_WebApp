using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.BookingDtos
{
    public class CreateBookingDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public string PersonCount { get; set; }
        public string SpecialRequest { get; set; }
    }
}
