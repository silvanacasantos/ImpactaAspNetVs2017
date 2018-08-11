using Oficina.Dominio;
using Oficina.Repositorios.SistemaDeArquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {
        //fildes
        private VeiculoRepositorio _veiculoRepositorio = new VeiculoRepositorio();
        private MarcaRepositorio _marcarepositorio = new MarcaRepositorio();
        private ModeloRepositorio _modeloRepositorio = new ModeloRepositorio();
        private CorRepositorio _corRepositorio = new CorRepositorio();
        

        //proporties
        public List<Marca> Marcas { get; set; }
        public string MarcaSelecionada { get; set; }
        public List<Modelo> Modelos { get; set; } = new List<Modelo>();
        public List<Cor> Cores { get; set; }
        public List<Combustivel> Combustiveis { get; set; }
        public List<Cambio> Cambios { get; set; }

        //metodo construtor
        public VeiculoAplicacao()
        {
            PopularControles();
        }
        
        //metodo
        private void PopularControles()
        {
            //Prencher os combos.box
            Marcas = _marcarepositorio.Selecionar();
            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"]; //dispara uma requisicao para o servidor passando pela url e retornando a informacao necessária

            if (!string.IsNullOrEmpty(MarcaSelecionada))//se a marca selecionada estiver preenchida
            {
                Modelos = _modeloRepositorio
                    .SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));
            }

            Cores = _corRepositorio.Selecionar();

            Combustiveis = Enum.GetValues(typeof(Combustivel)).Cast<Combustivel>().ToList();
            Cambios = Enum.GetValues(typeof(Cambio)).Cast<Cambio>().ToList();

        }

        public void Inserir()
        {
            try
            {
                var veiculo = new VeiculoPasseio();
                var formulario = HttpContext.Current.Request.Form;

                veiculo.Ano = Convert.ToInt32(formulario["ano"]);
                veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]);
                veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]);
                veiculo.Cor = _corRepositorio.Selecionar(Convert.ToInt32(formulario["cor"]));
                veiculo.Modelo = _modeloRepositorio.SelecionarPorModelo(Convert.ToInt32(formulario["modelo"]));
                veiculo.Observacao = formulario["observacao"];
                veiculo.Placa = formulario["placa"]/*.ToUpoer()*/;
                veiculo.Carroceria = TipoCarroceria.Hatch;

                _veiculoRepositorio.Inserir(veiculo);
            }
            catch (FileNotFoundException ex)
            {
                HttpContext.Current.Items.Add("MensagemErro", $"Arquivo{ex.FileName} não encontrado.");

                throw;
            }
            catch (UnauthorizedAccessException)
            {
                HttpContext.Current.Items.Add("MensagemErro", "Arquivo sem permissao de gravação.");

                throw;
            }
            catch (DirectoryNotFoundException)
            {
                HttpContext.Current.Items.Add("MensagemErro", "Caminho não encontrado.");

                throw;
            }
            catch (Exception excecao)
            {
                HttpContext.Current.Items.Add("MensagemErro", "Ooops! Ocorreu um erro.");

                throw;
                //throw excecao;  (outra forma de trazer o erro, não enxerga o detalhe, traz somente a ultima)
                //logar o objeto excecao.
                //log4net
            }
            finally
            {
                //é executado sempre, independente de sucesso ou erro.
                //executado mesmo se tenha um return.
                //usar o try cat finally para abrir fechar a conexao com o banco.
            }
        }
    }
}