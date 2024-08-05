using AutoMapper;
using EduDom.Core.Aplication.Interface.Repositories;
using EduDom.Core.Aplication.Interface.Service;
using EduDom.Core.Application.Interfaces;
using EduDom.Core.Domain.Entities;
using EduDomAplication.Service;
namespace EduDom.Core.Aplication.Service
{
    public class TimeClassService : GenericService<TimeClassSaveViewModel, TimeClassViewModels, TimeClass>, ITimeClass 
    {
        public TimeClassService(IGenericRepository<TimeClass> repository, IMapper mapper)
           : base(repository, mapper)
        {
        }
    }
}
