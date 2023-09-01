namespace Dominio.Entities;

public class RegistroDevolucion : BaseEntity
{
    public int IdAlquilerFk { get; set; }
    public Alquiler Alquiler { get; set; }
    public int IdEmpleadoFk { get; set; }
    public Empleado Empleado { get; set; }
    public DateOnly FechaDevolucion { get; set; }
    public decimal CombustibleDevuelto { get; set; }
    public int KilometrajeDevuelto { get; set; }
    public decimal MontoAdicional { get; set; }

    

}
