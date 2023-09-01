using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Person : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public ICollection<Reserva> reservas { get; set; }
        public ICollection<Alquiler> Alquileres { get; set; }

    }
}