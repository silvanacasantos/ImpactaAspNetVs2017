using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViagensOnLine.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagensOnLine.Dominio;

namespace ViagensOnLine.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class ViagensOnLineDbContextTests
    {
        private ViagensOnLineDbContext _db = new ViagensOnLineDbContext();

        [TestMethod()]
        public void InserirTeste()
        {
            var destino = new Destino();
            destino.Cidade = "São Paulo";
            destino.Nome = "Conheça São Paulo";
            destino.NomeImagem = "Paulista.png";
            destino.Pais = "Brasil";

            _db.Destinos.Add(destino);

            _db.SaveChanges();

        }

        [TestMethod]
        public void AtualizarTeste()
        {
            var destino = _db.Destinos.Find(1);
            destino.Pais = "Brazil";
            destino.Cidade = "Recife";
            _db.SaveChanges();
        }

        [TestMethod]
        public void ExcluirTeste()
        {
            var destino = _db.Destinos.Find(1);
            _db.Destinos.Remove(destino);
            _db.SaveChanges();
        }
    }
}