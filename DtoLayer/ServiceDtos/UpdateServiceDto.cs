using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}
