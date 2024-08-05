using AutoMapper;
using EduDom.Core.Aplication.Interface.Service;
using EduDom.Core.Aplication.ViewModels.User;
using EduDom.Core.Domain.Entities;
using EduDomAplication.Service;
using EduDom.Core.Aplication.Interface.Repositories;


namespace EduDom.Core.Aplication.Service
{
    public class UserService : GenericService <UserSaveViewModels, UserViewModels, User>, IUserService
    {
        public UserService(IGenericRepository<User> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
