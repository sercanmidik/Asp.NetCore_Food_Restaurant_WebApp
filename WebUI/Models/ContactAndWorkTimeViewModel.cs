using DtoLayer.ContactDtos;
using DtoLayer.WorkTimeDtos;

namespace WebUI.Models
{
    public class ContactAndWorkTimeViewModel
    {
        public ResultContactDto Contact { get; set; }
        public ResultWorkTimeDto WorkTime { get; set; }
    }
}
