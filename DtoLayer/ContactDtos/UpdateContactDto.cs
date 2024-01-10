﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string FoodBasketUrl { get; set; }
        public string FrameString { get; set; }
        public bool Status { get; set; }
    }
}
