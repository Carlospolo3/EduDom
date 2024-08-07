﻿using System;
using EduDom.Infraestructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Infraestructure.Identity.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //FLUENT API

            base.OnModelCreating(mb);
            mb.HasDefaultSchema("Identity");

            #region tables
            mb.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            mb.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            mb.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });

            mb.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });
            #endregion

        }
    }
}
