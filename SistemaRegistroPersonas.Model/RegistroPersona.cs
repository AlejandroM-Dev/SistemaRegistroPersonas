using System;
using System.Collections.Generic;

namespace SistemaRegistroPersonas.Models;

public partial class RegistroPersona
{
    public int IdRegistro { get; set; }

    public int Identificacion { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public long? Celular { get; set; }

    public long? TelefonoAlternativo { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? CorreoElectronicoAlternativo { get; set; }

    public string? Direccion { get; set; }

    public string? DireccionAltenativa { get; set; }
}
