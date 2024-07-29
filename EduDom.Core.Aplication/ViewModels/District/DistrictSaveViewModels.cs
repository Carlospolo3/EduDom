using EduDom.Core.Aplication.ViewModels.Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.ViewModels.District
{
    public class DistrictSaveViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProvinceViewModels Province { get; set; }
    }

}
