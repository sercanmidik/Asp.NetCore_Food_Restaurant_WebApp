using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.EntryDtos
{
    public class UpdateEntryDto
    {
        public int EntryId { get; set; }
        public string TitleOne { get; set; }
        public string TitleTwo { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
