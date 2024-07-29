using System.Reflection;
using Microsoft.EntityFrameworkCore;
using EduDom.Core.Domain.Common;
using EduDom.Core.Domain.Entities;
using Microsoft.AspNetCore.Http;
using EduDom.Core.Aplication.ViewModels.User;
using EduDomAplication.Helpers;


namespace EduDom.Infraestructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private UserViewModels user = new();

        public ApplicationContext(DbContextOptions<ApplicationContext> options, IHttpContextAccessor http) : base(options)
        {
            _httpContextAccessor = http;
        }

        #region dbSets -->
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Employeer> Employers { get; set; }
        public DbSet<Province> Provinces { get; set; }

        public DbSet<Qualifications> Qualifications { get; set; }
        public DbSet<Registration> Regions { get; set; }
        public DbSet<School> schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }

        public DbSet<TimeClass> TimeClasses { get; set; }

        public DbSet<User> users { get; set; }

        #endregion

        public override Task<int> SaveChangesAsync(CancellationToken ct = default(CancellationToken))
        {
            
            if (_httpContextAccessor.HttpContext != null)
            {
                user = _httpContextAccessor.HttpContext.Session.Get<UserViewModels>("user");
            }

            
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                if (entry.Entity != null)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.Entity.Created = DateTime.Now;
                            entry.Entity.CreatedBy = user?.Username ?? "Unknown";  
                            break;
                        case EntityState.Modified:
                            entry.Entity.LastModified = DateTime.Now;
                            entry.Entity.ModifiedBy = user?.Username ?? "Unknown";  
                            break;
                    }
                }
            }

            return base.SaveChangesAsync(ct);
        }


    }
}
