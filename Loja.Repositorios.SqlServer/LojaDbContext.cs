using Loja.Dominio;
using Loja.Repositorios.SqlServer.Migrations;
using Loja.Repositorios.SqlServer.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Repositorios.SqlServer
{
    //Design pattern: Unit of Work
    public class LojaDbContext : DbContext
    {
        public LojaDbContext():base("lojaConnectionString")
        {
            //apostila pag.191
            //Database.SetInitializer(new LojaDbInitializer()); dropa e recria o banco caso ele mude.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LojaDbContext,Configuration>());
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
