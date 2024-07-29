using EduDom.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Repositories
{
    public class TimeClassRepository : IGenericRepository<TimeClass>
    {
        public Task<TimeClass> AddAsync(TimeClass entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TimeClass entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TimeClass>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<TimeClass>> GetAllWithIncludeAsync(List<string> props)
        {
            throw new NotImplementedException();
        }

        public Task<TimeClass> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TimeClass entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
