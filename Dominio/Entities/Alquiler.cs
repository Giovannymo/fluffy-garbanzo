

using System.Runtime.CompilerServices;

namespace Dominio.Entities
{
    public class Alquiler
    {
        public int IdAquiler { get; set; }
        public int IdClienteFK { get; set;}
        public int IdAutomovilFK {get; set;}
        public DateTime FechaInicio {get; set;}
        public DateTime FechaFin {get; set;}
        public decimal CostoTotal {get; set;}
        public string Estado {get; set;}
    }
}