using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.AboutDto
{
    public class ResultAboutDto
    {
        public int AboutId { get; set; }
        public string TitleOne { get; set; }
        public string Icon { get; set; }
        public string TitleTwo { get; set; }
        public string ContentOne { get; set; }
        public string ContentTwo { get; set; }
        public string ImageUrlOne { get; set; }
        public string ImageUrlTwo { get; set; }
        public string ImageUrlThree { get; set; }
        public string ImageUrlFour { get; set; }
        public int ServiceTime { get; set; }
        public int PersonCount { get; set; }
        public bool Status { get; set; }
    }
}
