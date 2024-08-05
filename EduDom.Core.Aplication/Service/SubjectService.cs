using AutoMapper;
using EduDom.Core.Aplication.Interface.Repositories;
using EduDom.Core.Aplication.Interface.Service;
using EduDom.Core.Aplication.ViewModels.Subjects;
using EduDom.Core.Application.Interfaces;
using EduDom.Core.Domain.Entities;
using EduDomAplication.Service;

using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Service
{
    public class SubjectService : GenericService<SubjectsSaveViewModels, SubjectsViewModels, Subjects>, ISubjectService
    {
        public SubjectService(IGenericRepository<Subjects> repository, IMapper mapper)
           : base(repository, mapper)
        {
        }
    }



}
