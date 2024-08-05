using AutoMapper;
using EduDom.Core.Aplication.Interface.Repositories;
using EduDom.Core.Aplication.Interface.Service;
using EduDom.Core.Application.Interfaces;
using EduDom.Core.Domain.Entities;
using EduDomAplication.Service;

namespace EduDom.Core.Application.Service
{
    public class SchoolService : GenericService<SchoolSaveViewModels, SchoolViewModels, School>, ISchoolService
    {
        public SchoolService(IGenericRepository<School> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
