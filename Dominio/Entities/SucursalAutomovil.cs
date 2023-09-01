namespace Dominio.Entities;

    public class SucursalAutomovil
    {

        public int CantidadDisponible { get; set; }
        public int IdSucursalFk { get; set; }
        public Sucursal Sucursal { get; set; }
        public ICollection<Automovil> Automoviles { get; set; }
        
    }
