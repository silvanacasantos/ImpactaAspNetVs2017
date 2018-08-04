using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{   
    //oficina.dominio é a camada de modelo onde inserimos as regras
        // abstract não pode sert instanciada (new)  - Só usa abstract com herança
    public abstract class Veiculo  
    {
        //public Veiculo()
        //{
        //    Id = Guid.NewGuid();
        //}

        public Guid Id { get; set; } = Guid.NewGuid();
        
        private string _placa;     //como se fosse uma variável no nível de classe.
        //toDO: OO - ENCAPSULAMENTO PROPFULL TAB TAB CRIA O ENCAPSULAMENTO
        public string Placa 
        {
            get { return _placa.ToUpper(); }
            set { _placa = value.ToUpper(); }
        }

        //encapsulamento
        //para cada uma das properties pode ser inserido uma ou mais instrução no get ou set
        //public string Placa
        //{
        //    get
        //    {
        //        return _placa.ToUpper();
        //    }
        //    set
        //    {
        //        _placa = value.ToUpper();
        //    }
        //}

        public int Ano { get; set; }
        public string Observacao { get; set; }

        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }

        //criando método Validar (abstrato) - Na classe mãe(base) não dá para criar a validação. A validação é feita 'a partir da classe filha.
        public abstract List<string> Validar();


        //deverá retornar uma lista vazia = se retornar registro é porque tem erro
        protected List<string> ValidarBase()    //método protected só pode ser usado com herança --> somente os filhos enxergam este método.
        {
            var erros = new List<string>();

            if (Ano <=1940 || (Ano - DateTime.Now.Year >=2)) // (Ano - DateTime.Now.Year >=2  -->  ANO - ANO ATUAL
            {
                erros.Add($"O ano informado {Ano} é inválido.");
            }

            return erros;
        }
    }
}
