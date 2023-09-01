using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Automovil
    {
        public int idAutomovil { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public string tipo { get; set; }
        public int capacidad { get; set; }
        public decimal precioDiario { get; set; }
    }
}