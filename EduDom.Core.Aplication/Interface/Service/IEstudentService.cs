using EduDom.Core.Aplication.ViewModels.Estudent;
using EduDom.Core.Domain.Entities;


namespace EduDom.Core.Aplication.Interface.Service
{
    public interface IEstudentService : IGenericService <StudentSaveViewModels, StudentSaveViewModels, Student>
    {
    }
}

