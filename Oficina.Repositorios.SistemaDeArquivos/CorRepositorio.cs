using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Oficina.Repositorios.SistemaDeArquivos
{
    public class CorRepositorio
    {
        private string _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];

        public List<Cor> Selecionar()  // referencia a Classe Cor para reconhecer as camadas
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome=linha.Substring(5);
                
                cores.Add(cor);
            }

            return cores;
        }

        public Cor Selecionar(int corId)
        {
            Cor cor = null;   // var cor = new Cor();

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var linhaId = Convert.ToInt32(linha.Substring(0, 5));

                if (linhaId == corId)
                {
                    cor = new Cor();
                    cor.Id = linhaId;
                    cor.Nome = linha.Substring(5);
                                    
                    break; //interrompe o laço (loop) quando localizar o registro solicitado.
                    //return Cor; (outra forma é retornar o conteúdo aqui, mas não é eficaz)
                }
            }
            return cor;   //interrompe o método e traz o resultado da pesquisa
            //return Null;

        }
       
    }
}
