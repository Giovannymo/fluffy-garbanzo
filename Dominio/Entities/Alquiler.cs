

using System;

namespace Dominio.Entities
{
    public class Alquiler : BaseEntity
    {
        public int IdClienteFK { get; set;}
        public int IdAutomovilFK {get; set;}
        public DateTime FechaInicio {get; set;}
        public DateTime FechaFin {get; set;}
        public decimal CostoTotal {get; set;}
        public string Estado {get; set;}
    }
}