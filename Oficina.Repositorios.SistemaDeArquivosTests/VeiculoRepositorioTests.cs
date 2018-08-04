﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaDeArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var repositorio = new VeiculoRepositorio();

            var veiculo = new VeiculoPasseio();
            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Automatico;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            //veiculo.Id = 1;
            veiculo.Modelo = new ModeloRepositorio().SelecionarPorModelo(3);
            veiculo.Observacao = "Observação";
            veiculo.Placa = "GGK-9888";
            veiculo.Carroceria = TipoCarroceria.Hatch;

            new VeiculoRepositorio().Inserir(veiculo);

         }
    }
}