using EduDom.Core.Aplication.ViewModels.District;
using EduDom.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Service
{
    public interface IDistricService : IGenericService <DistrictSaveViewModels, DistrictViewModels, District >
    {
    }
}
