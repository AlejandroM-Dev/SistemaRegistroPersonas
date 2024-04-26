namespace SistemaRegistroPersonas.App.Models.ViewModels
{
    public class VMRegistro
    {
        public int IdRegistro { get; set; }

        public string Identificacion { get; set; }

        public string? Nombres { get; set; }

        public string? Apellidos { get; set; }

        public string? FechaNacimiento { get; set; }

        public string? Celular { get; set; }

        public string? TelefonoAlternativo { get; set; }

        public string? CorreoElectronico { get; set; }

        public string? CorreoElectronicoAlternativo { get; set; }

        public string? Direccion { get; set; }

        public string? DireccionAltenativa { get; set; }
    }
}
