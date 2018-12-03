using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ucare.Datos.Mapping.Almacen;
using Ucare.Datos.Mapping.Usuarios;
using Ucare.Entidades.Almacen;
using Ucare.Entidades.Usuarios;

namespace Ucare.Datos
{
   public class DbContextSistema : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new RolMap());

        }

    }


}
