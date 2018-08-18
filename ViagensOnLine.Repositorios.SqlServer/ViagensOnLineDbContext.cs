using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagensOnLine.Dominio;

namespace ViagensOnLine.Repositorios.SqlServer
{
    public class ViagensOnLineDbContext : DbContext
    {
        //ctro cria um construtor : ()base faz herdar do construturo do dbContext
        public ViagensOnLineDbContext(): base("viagensOnLineConnectionString")
        {

        }
        public DbSet<Destino> Destinos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
