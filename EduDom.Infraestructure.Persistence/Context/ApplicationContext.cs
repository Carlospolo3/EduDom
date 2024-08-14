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
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //private UserViewModels user = new();

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //_httpContextAccessor = http;
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

        public DbSet<Schedule> TimeClasses { get; set; }

        public DbSet<User> users { get; set; }

        #endregion

        //public override Task<int> SaveChangesAsync(CancellationToken ct = default(CancellationToken))
        //{

        //    if (_httpContextAccessor.HttpContext != null)
        //    {
        //        user = _httpContextAccessor.HttpContext.Session.Get<UserViewModels>("user");
        //    }


        //    foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
        //    {
        //        if (entry.Entity != null)
        //        {
        //            switch (entry.State)
        //            {
        //                case EntityState.Added:
        //                    entry.Entity.Created = DateTime.Now;
        //                    entry.Entity.CreatedBy = user?.Username ?? "Unknown";
        //                    break;
        //                case EntityState.Modified:
        //                    entry.Entity.LastModified = DateTime.Now;
        //                    entry.Entity.ModifiedBy = user?.Username ?? "Unknown";
        //                    break;
        //            }
        //        }
        //    }

        //    return base.SaveChangesAsync(ct);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=CM2022\\SQLSERVER; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True; Initial Catalog=EDUDOM");
            }
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            #region Tables
            model.Entity<Assignment>().ToTable("Asignaciones");
            model.Entity<Attendance>().ToTable("Asistencia");
            model.Entity<Course>().ToTable("Aula");
            model.Entity<Department>().ToTable("Departamento");
            model.Entity<District>().ToTable("Distrito");
            model.Entity<Employeer>().ToTable("Empleado");
            model.Entity<Province>().ToTable("Provincia");
            model.Entity<Qualifications>().ToTable("Calificaciones");
            model.Entity<Registration>().ToTable("Registro");
            model.Entity<Reports>().ToTable("Reportes");
            model.Entity<Role>().ToTable("Roles");
            model.Entity<Schedule>().ToTable("Horario");
            model.Entity<School>().ToTable("Escuela");
            model.Entity<Student>().ToTable("Estudiante");
            model.Entity<Subjects>().ToTable("Materia");
            model.Entity<Teacher>().ToTable("Profesor");
            model.Entity<User>().ToTable("Usuario");
            #endregion

            #region Primary Keys
            model.Entity<Course>().HasKey(e => e.Id);
            model.Entity<Subjects>().HasKey(e => e.Id);
            model.Entity<Assignment>().HasKey(e => e.Id);
            model.Entity<Attendance>().HasKey(e => e.Id);
            model.Entity<Department>().HasKey(e => e.Id);
            model.Entity<District>().HasKey(e => e.Id);
            model.Entity<Employeer>().HasKey(e => e.Id);
            model.Entity<Province>().HasKey(e => e.Id);
            model.Entity<Qualifications>().HasKey(e => e.Id);
            model.Entity<Registration>().HasKey(e => e.Id);
            model.Entity<Reports>().HasKey(e => e.Id);
            model.Entity<Role>().HasKey(e => e.Id);
            model.Entity<Schedule>().HasKey(e => e.Id);
            model.Entity<School>().HasKey(e => e.Id);
            model.Entity<Student>().HasKey(e => e.Id);
            model.Entity<Teacher>().HasKey(e => e.Id);
            model.Entity<User>().HasKey(e => e.Id);
            #endregion

            #region Foreign Keys
            model.Entity<Subjects>()
         .HasMany(e => e.Assignments)
         .WithOne(e => e.Subjects)
         .HasForeignKey(e => e.SubjectId)
         .OnDelete(DeleteBehavior.Restrict); //Verificar eliminacion

            model.Entity<Student>()
                .HasMany(e => e.Attendances)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Teacher>()
                .HasMany(e => e.Attendances)
                .WithOne(e => e.Teacher)
                .HasForeignKey(e => e.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Course>()
                .HasMany(e => e.Assignments)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Restrict); //Verificar eliminacion, para que no haya id vacios

            model.Entity<Department>()
                .HasMany(e => e.Employeers)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Province>()
                .HasMany(e => e.Districts)
                .WithOne(e => e.Province)
                .HasForeignKey(e => e.ProvinceId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<School>()
                .HasMany(e => e.Departments)
                .WithOne(e => e.School)
                .HasForeignKey(e => e.SchoolId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Course>()
                .HasMany(e => e.Students)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Course>()
                .HasMany(e => e.Schedules)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Teacher>()
                .HasMany(e => e.Schedules)
                .WithOne(e => e.Teacher)
                .HasForeignKey(e => e.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Student>()
                .HasMany(e => e.Reports)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Student>()
                .HasMany(e => e.Qualifications)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Restrict); //Verificar eliminacion

            model.Entity<Subjects>()
                .HasMany(e => e.Qualifications)
                .WithOne(e => e.Subject)
                .HasForeignKey(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Restrict); //Verificar Eliminacion

            #endregion

            #region Properties
            #endregion
        }


    }
}
