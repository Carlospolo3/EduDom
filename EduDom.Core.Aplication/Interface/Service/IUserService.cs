using EduDom.Core.Aplication.ViewModels.Attendance;
using EduDom.Core.Aplication.ViewModels.User;
using EduDom.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Service
{
    public interface IUserService : IGenericService<UserSaveViewModels, UserViewModels, User>
    {
    }
}
