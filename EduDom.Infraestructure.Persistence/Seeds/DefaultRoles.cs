using EduDom.Core.Domain.Entities;
using EduDom.Infraestructure.Persistence.Context;


namespace EduDom.Infraestructure.Persistence.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(ApplicationContext context)
        {
            await context.Set<Role>().AddRangeAsync(
                new Role { RoleName = "Administrador"},
                new Role { RoleName = "Empleado"},
                new Role { RoleName = "Profesor"},
                new Role { RoleName = "Estudiante"}
                );
            await context.SaveChangesAsync();
        }
    }
}
