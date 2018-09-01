using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pessoal.Dominio;
using Pessoal.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoal.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class TarefaRepositorioTests
    {
        private TarefaRepositorio _tarefarepositorio = new TarefaRepositorio();

        [TestMethod()]
        public void InserirTest()
        {
            var tarefa = new Tarefa();
            tarefa.Concluida = false;
            tarefa.Nome = "Lavar Roupas";
            tarefa.Prioridade = Prioridade.Alta;
            tarefa.Observacoes = "Urgente";

            tarefa.Id = _tarefarepositorio.Inserir(tarefa);

            Assert.AreNotEqual(tarefa.Id, 0);
        }

        [TestMethod()]
        public void AtualizarTest()
        {
            var tarefa = _tarefarepositorio.Selecionar().First();
            tarefa.Nome = "Lavar muita roupa";
            tarefa.Observacoes = "Muito chato fazer isto";
            tarefa.Concluida = true;
            tarefa.Prioridade = Prioridade.Baixa;

            _tarefarepositorio.Atualizar(tarefa);

        }

        [TestMethod()]
        public void ExcluirTest()
        {
             _tarefarepositorio.Excluir(1);

            var tarefa = _tarefarepositorio.Selecionar(1);
            Assert.IsNull(tarefa);
        }
    }
}