using System.ComponentModel;

namespace Oficina.Dominio
{
    public enum Cambio
    {
        [Description("Automático")]
        Automatico = 1,

        [Description("Semi-Automático")]
        Semi_Automatico = 2,

        Manual = 3
    }
}