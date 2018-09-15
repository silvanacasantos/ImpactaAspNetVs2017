using System;
using System.Collections.Generic;
using System.Data.Entity;
using Loja.Dominio;

namespace Loja.Repositorios.SqlServer
{
    internal class LojaDbInitializer : DropCreateDatabaseIfModelChanges<LojaDbContext>
    {
        protected override void Seed(LojaDbContext context)
        {
            context.Produtos.AddRange(ObterProdutos());

            context.SaveChanges();
        }

        private IEnumerable<Produto> ObterProdutos()
        {
            var barbeador = new Produto();
            barbeador.Estoque = 45;
            barbeador.Nome = "Barbeador";
            barbeador.Preco = 17.41m;
            barbeador.Unidade = "Caixa";
            barbeador.Categoria = new Categoria { Nome = "Perfumaria" };

            var teclado = new Produto();
            teclado.Estoque = 45;
            teclado.Nome = "Teclado";
            teclado.Preco = 17.41m;
            teclado.Unidade = "PC";
            teclado.Categoria = new Categoria { Nome = "Informatica" };

            return new List<Produto> {barbeador,teclado };
        }
    }
}