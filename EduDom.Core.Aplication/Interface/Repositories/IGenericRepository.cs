using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.Interface.Repositories
{
    public interface IGenericRepository<Entity>:IRepositoryBase<Entity> where Entity : class
    {
        
    }

    public interface IGenericReadRepository<Entity>:IReadRepositoryBase<Entity> where Entity : class
    {

    }
}
