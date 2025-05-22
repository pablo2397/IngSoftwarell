namespace Entities;

public partial class Vehiculo
{
    public int IdVehiculo { get; set; }

    public string TipoVehiculo { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Kilometraje { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public bool Estado { get; set; }
}
