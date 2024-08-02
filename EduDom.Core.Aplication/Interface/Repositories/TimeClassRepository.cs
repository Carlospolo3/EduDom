using EduDom.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Repositories
{
    public class TimeClassRepository : IGenericRepository<Schedule>
    {
        public Task<Schedule> AddAsync(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Schedule>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Schedule>> GetAllWithIncludeAsync(List<string> props)
        {
            throw new NotImplementedException();
        }

        public Task<Schedule> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Schedule entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
