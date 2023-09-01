namespace Dominio.Entities;

public class RegistroEntrega : BaseEntity
{
    public DateTime FechaEntrega { get; set; }
    public decimal CombustibleEntregado { get; set; }
    public int KilometrajeEntregado { get; set; }
    public int IdAlquilerFK { get; set; }
    public Alquiler Alquiler { get; set; }
    public int IdPersonaFK { get; set; }
    public Persona Persona { get; set; }
}