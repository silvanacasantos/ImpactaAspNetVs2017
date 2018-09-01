using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorios.SqlServer.ModelConfiguration
{
    class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            Property(p => p.Nome)
             .IsRequired()
             .HasMaxLength(200);
        }
    }
}