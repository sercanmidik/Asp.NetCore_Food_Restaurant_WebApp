using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public string PersonCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Status { get; set; }
    }
}
