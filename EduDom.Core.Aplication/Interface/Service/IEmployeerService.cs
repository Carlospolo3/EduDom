using EduDom.Core.Aplication.ViewModels.Employeer;
using EduDom.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Service
{
    public interface IEmployeerService : IGenericService <EmployeerSaveViewModel, EmployeerViewModels, Employeer>
    {
    }
}
