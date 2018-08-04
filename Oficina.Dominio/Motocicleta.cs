using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //termo de herança motocicleta herda de veiculo (:) simbologia de herença
    //herança no C# é única. O que aparece depois dos dos pontos é a classe mãe

    public class Motocicleta : Veiculo
    {
        public TipoMotocicleta TipoMotocicleta { get; set; }

        public override List<string> Validar() //está substituindo o valor que está na classe mãe(base)
        {
            throw new NotImplementedException();
        }
    }
}
