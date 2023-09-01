namespace Dominio.Entities;

public class RegistroEntrega
{
    public int Id { get; set; }
    public DateTime FechaEntrega { get; set; }
    public decimal CombustibleEntregado { get; set; }
    public int KilometrajeEntregado { get; set; }
    
}