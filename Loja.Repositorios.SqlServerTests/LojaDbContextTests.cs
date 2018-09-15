using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Loja.Dominio;
using System.Data.Entity;


namespace Loja.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class LojaDbContextTests
    {
        private static LojaDbContext db = new LojaDbContext();

        [ClassInitialize]
        public static void Inicializar(TestContext context)
        {
            db.Database.Log = q => context.WriteLine(q);
        }

        [TestMethod()]
        public void InserirCategoriaTest()
        {
            var papelaria = new Categoria();
            papelaria.Nome = "Papelaria";

            db.Categorias.Add(papelaria);

            var informatica = new Categoria();
            informatica.Nome = "Informática";

            db.Categorias.Add(informatica);

            db.SaveChanges();
        }

        [TestMethod]
        public void InserirProdutoTest()
        {
            var caneta = new Produto();
            caneta.Estoque = 15;
            caneta.Nome = "Caneta";
            caneta.Preco = 16.30m;
            //produto.Categoria = db.Categorias.Where(c => c.Id == 1).SingleOrDefault();
            caneta.Categoria = db.Categorias.Find(1);
            caneta.Categoria = db.Categorias.SingleOrDefault(c => c.Id == 1);

            var barbeador = new Produto();
            barbeador.Estoque = 45;
            barbeador.Nome = "Barbeador";
            barbeador.Preco = 17.41m;
            barbeador.Categoria = new Categoria { Nome = "Perfumaria" };

            db.Produtos.Add(caneta);
            db.Produtos.Add(barbeador);
            
            db.SaveChanges();
        }

        [TestMethod]
        public void EditarProdutoTest()
        {
            var barbeador = db.Produtos
                //.Where(produto => produto.Nome == "Barbeador") quando utilizamos o singleordefault não traz necessita where, porque permite inserir os critérios.
                .SingleOrDefault(produto => produto.Nome == "Barbeador");
                //.Single(); retorna um, se houver mais de um produto com o mesmo nome retorna uma exception
                //.First(); retorna o primeiro de uma lista
                //.OrderBy(produto => produto.Nome)
                //.GroupBy();
            barbeador.Preco = 9.45m;
            db.SaveChanges();

            barbeador = db.Produtos.SingleOrDefault(produto => produto.Nome == "Barbeador");

            Assert.AreEqual(barbeador.Preco, 9.45m);
        }

        [TestMethod]
        public void ExcluirProdutoTest()
        {
            var  barbeador = db.Produtos.SingleOrDefault(produto => produto.Nome == "Barbeador");

            db.Produtos.Remove(barbeador);

            db.SaveChanges();

            barbeador = db.Produtos.SingleOrDefault(produto => produto.Nome == "Barbeador");

            Assert.IsNull(barbeador);
        }

        [TestMethod]
        public void LazyLoadTeste()
        {
            var caneta = db.Produtos.SingleOrDefault(produto => produto.Nome == "Caneta");

            Console.WriteLine(caneta.Categoria.Nome);
        }

        [TestMethod]
        public void IncludeTeste()
        {
            //(p =>p.Categoria) -> lambida expression
            var caneta = db.Produtos.Include(p =>p.Categoria).SingleOrDefault(produto => produto.Nome == "Caneta");

            //var query = db.Database.ExecuteSqlCommand(""); poderá fazer a query do sql dentro dos parenteses e não usar a lambida expression
            Console.WriteLine(caneta.Categoria.Nome);

        }

        [TestMethod]
        public void QueryableTeste()
        {
            bool consultarEstoque = true;
            var query = db.Produtos.Where(p => p.Preco > 2);

            if (consultarEstoque)
            {
                query = query.Where(p => p.Estoque > 4);
            }

            query = query.OrderBy(p => p.Preco);

            //disparam a consulta no banco:
            var primeiro = query.First(); //aceita lambida
            var ultimo = query.AsEnumerable().Last();
            //var unico = query.Single();  //aceita lambida
            var todos = query.ToList();

        }
    }
}