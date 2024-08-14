using Ardalis.Specification.EntityFrameworkCore;
using EduDom.Core.Aplication.Interface.Repositories;
using EduDom.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Infraestructure.Persistence.Repositories
{
    public class GenericRepository<Entity> : RepositoryBase<Entity>, IGenericRepository<Entity> where Entity : class
    {
        private readonly ApplicationContext _context;

        public GenericRepository(ApplicationContext context):base(context)
        {
            _context = context;
        }
    }
}
