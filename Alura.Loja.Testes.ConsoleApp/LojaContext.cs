using System;
using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        //essa implementação permite que possa ser usado qualquer tipo de banco
        public LojaContext()
        {

        }


        //essa implementação permite que possa ser usado qualquer tipo de banco

        public LojaContext(DbContextOptions<LojaContext> options): base(options)
        {

        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //essa implementação permite que possa ser usado qualquer tipo de banco
            if (!optionsBuilder.IsConfigured)
            {
                //se for usar só um banco não precisa da validação OsConfigured
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");  optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;"); optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            }

          
        }
    }
}