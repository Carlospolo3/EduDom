using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Service
{
    public interface IGenericService<SaveViewModel, ViewModel, Entity>
     where SaveViewModel : class
     where ViewModel : class
     where Entity : class
    {
        Task<SaveViewModel> Add(SaveViewModel viewModel);
        Task Update(SaveViewModel vm, int id);
        Task Delete(int id);
        Task<SaveViewModel> GetByIdSaveViewModel(int id);
        Task<List<ViewModel>> GetAllViewModel();
    }
}
