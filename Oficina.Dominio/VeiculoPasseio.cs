using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //ToDo:OO (Orientação Objeto) - classe ou abstração. 
    //ToDo: OO : Veiculo - (:) representa herança.
    public class VeiculoPasseio : Veiculo
    {
        public TipoCarroceria Carroceria { get; set; }

        //ToDo: OO - Polimofirmos por sbustituição (override).  Para recuperar os ToDo´s clicar em: Menu>Exibir>Lista de tarefas (apresenta na parte inferior todos os ToDo criado em todos os prejetos.
        public override List<string> Validar()
        {
            var erros = base.ValidarBase();

            if (!Enum.IsDefined(typeof(TipoCarroceria),Carroceria))
            {
                erros.Add($"A carroceria informada ({Carroceria}) não é valida.");
            }

            return erros;
        }
    }
}
