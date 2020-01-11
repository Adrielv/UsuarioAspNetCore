using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioAspNetCore.Models;

namespace UsuarioAspNetCore.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (Local); Database = TestDb; Trusted_Connection = True;");
        }
        //public Context(DbContextOptions<Context> options) : base(options)
        //{
        //} 
    }
}
