using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Empleado
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Dni {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        public string Cargo {get; set;}

        public override string ToString()
        {
            return $"Hola, Soy Mario, llámame {Telefono} (solo hombres)";
        }
        
    }
}