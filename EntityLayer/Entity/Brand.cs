using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Status { get; set; }
    }
}
