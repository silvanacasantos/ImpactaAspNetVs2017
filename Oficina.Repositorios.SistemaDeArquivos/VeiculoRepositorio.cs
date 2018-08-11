using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemaDeArquivos
{
   public class VeiculoRepositorio
    {
        private string _caminhoArquivo;
        private XDocument _arquivoXml;

        public VeiculoRepositorio() //metrodo construtor é chamado na classe através do new
        {

         _caminhoArquivo = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,ConfigurationManager.AppSettings["caminhoArquivoVeiculo"]);
         
        }
        
        public void Inserir<T>(T veiculo) where T: Veiculo  //meu metodo passa a ser generico <T> (T = Tipo), usando o conceito herança, desque que o tipo seja um Veiculo
        {
            _arquivoXml = XDocument.Load(_caminhoArquivo);

            var registro = new StringWriter();
            new XmlSerializer(typeof(T)).Serialize(registro,veiculo);

            _arquivoXml.Root.Add(XElement.Parse(registro.ToString()));
            _arquivoXml.Save(_caminhoArquivo);
        }
    }
}
