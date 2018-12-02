using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ucare.Datos.Mapping.Almacen;
using Ucare.Entidades.Almacen;

namespace Ucare.Datos
{
    class DbContextSistema : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }

        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());

        }

    }


}
