using DtoLayer.AboutDto;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService:IGenericService<About>
    {
        public ResultAboutDto BusinesGetOneAbout();
    }
 
}
