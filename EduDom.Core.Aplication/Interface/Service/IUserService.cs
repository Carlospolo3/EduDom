using EduDom.Core.Aplication.ViewModels.User;
using EduDom.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Service
{
    public class IUserService : IGenericService<UserSaveViewModels, UserViewModels, User>
    {
        public Task<UserSaveViewModels> Add(UserSaveViewModels viewModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserViewModels>> GetAllViewModel()
        {
            throw new NotImplementedException();
        }

        public Task<UserSaveViewModels> GetByIdSaveViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserSaveViewModels vm, int id)
        {
            throw new NotImplementedException();
        }
    }
}
