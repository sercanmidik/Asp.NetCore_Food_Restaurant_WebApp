using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class WorkTime
    {
        public int WorkTimeId { get; set; }
        public string BeginDay { get; set; }
        public string FinishDay { get; set; }
        public string BeginTime { get; set; }
        public string FinishTime { get; set; }
        public bool Status { get; set; }
    }
}
