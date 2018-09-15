using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Unidade { get; set; }
        public Boolean Ativo { get; set; }
        

        //virtual - habilita o lazy load do EF
        public virtual Categoria Categoria { get; set; }
    }
}
