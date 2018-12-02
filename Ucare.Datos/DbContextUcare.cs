using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ucare.Datos
{
    class DbContextUcare : DbContext
    {

        public DbContextUcare(DbContextOptions<DbContextUcare> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);

        }

    }


}
