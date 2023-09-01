using System;
using Microsoft.VisualBasic;

namespace Dominio.Entidades
{
    public class Reserva
    {
        public int IdReserva {get; set;} 
        public int IdClienteFK {get; set;}
        public int IdAutomovilFK {get; set;}
        public DateTime FechaReserva {get; set;}
        public DateTime FechaInicio {get; set;}
        public DateTime FechaFin {get; set;}

        public string Estado {get; set;}
    }
}