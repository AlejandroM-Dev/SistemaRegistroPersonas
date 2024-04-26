using Microsoft.AspNetCore.Mvc;
using SistemaRegistroPersonas.App.Models;
using SistemaRegistroPersonas.App.Models.ViewModels;
using SistemaRegistroPersonas.BLL.Service;
using SistemaRegistroPersonas.Models;
using System.Diagnostics;
using System.Globalization;

namespace SistemaRegistroPersonas.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegistroPersonasService _registroPersonasService;

        public HomeController(IRegistroPersonasService registroPersonasService)
        {
            _registroPersonasService = registroPersonasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            IQueryable<RegistroPersona> queryRegistro = await _registroPersonasService.ObtenerTodos();
            List<VMRegistro> lista = queryRegistro
                                    .Select(x => new VMRegistro(){
                                        IdRegistro = x.IdRegistro,
                                        Identificacion = x.Identificacion.ToString(),
                                        Nombres = x.Nombres,
                                        Apellidos = x.Apellidos,
                                        FechaNacimiento = x.FechaNacimiento.Value.ToString("dd/MM/yyyy"),
                                        Celular = x.Celular.ToString(),
                                        TelefonoAlternativo = x.TelefonoAlternativo.ToString(),
                                        CorreoElectronico = x.CorreoElectronico,
                                        CorreoElectronicoAlternativo = x.CorreoElectronicoAlternativo,
                                        Direccion = x.Direccion,
                                        DireccionAltenativa = x.DireccionAltenativa
                                    }).ToList();
            return StatusCode(StatusCodes.Status200OK, lista);
        }

        [HttpPost]
        public async Task<IActionResult> Insertar([FromBody] VMRegistro modelo)
        {
            RegistroPersona NuevoModelo = new RegistroPersona()
            {
                Identificacion = int.Parse(modelo.Identificacion),
                Nombres = modelo.Nombres,
                Apellidos = modelo.Apellidos,
                FechaNacimiento = DateTime.ParseExact(modelo.FechaNacimiento,"dd/MM/yyyy",CultureInfo.CreateSpecificCulture("es-CO")),
                Celular = !string.IsNullOrEmpty(modelo.Celular) ? long.Parse(modelo.Celular) : (long?)null,
                TelefonoAlternativo = !string.IsNullOrEmpty(modelo.TelefonoAlternativo) ? long.Parse(modelo.TelefonoAlternativo) : (long?)null,
                CorreoElectronico = modelo.CorreoElectronico,
                CorreoElectronicoAlternativo = modelo.CorreoElectronicoAlternativo,
                Direccion = modelo.Direccion,
                DireccionAltenativa = modelo.DireccionAltenativa
            };
            bool res = await _registroPersonasService.Insertar(NuevoModelo);
            return StatusCode(StatusCodes.Status200OK, new { valor= res });
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar([FromBody] VMRegistro modelo)
        {
            RegistroPersona newModel = new RegistroPersona()
            {
                IdRegistro = modelo.IdRegistro,
                Identificacion = int.Parse(modelo.Identificacion),
                Nombres = modelo.Nombres,
                Apellidos = modelo.Apellidos,
                FechaNacimiento = DateTime.ParseExact(modelo.FechaNacimiento, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("es-CO")),
                Celular = !string.IsNullOrEmpty(modelo.Celular) ? long.Parse(modelo.Celular) : (long?)null,
                TelefonoAlternativo = !string.IsNullOrEmpty(modelo.TelefonoAlternativo) ? long.Parse(modelo.TelefonoAlternativo) : (long?)null,
                CorreoElectronico = modelo.CorreoElectronico,
                CorreoElectronicoAlternativo = modelo.CorreoElectronicoAlternativo,
                Direccion = modelo.Direccion,
                DireccionAltenativa = modelo.DireccionAltenativa
            };
            bool res = await _registroPersonasService.Actualizar(newModel);
            return StatusCode(StatusCodes.Status200OK, new { valor = res });
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int id)
        {
            bool res = await _registroPersonasService.Eliminar(id);
            return StatusCode(StatusCodes.Status200OK, new { valor = res });
        }

        [HttpGet]
        public async Task<IActionResult> Obtener(int id)
        {
            RegistroPersona res = await _registroPersonasService.Obtener(id);
            return StatusCode(StatusCodes.Status200OK, new { valor = res });
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerIdentificacion(int identificacion)
        {
            RegistroPersona res = await _registroPersonasService.ObtenerIdentificacion(identificacion);
            return StatusCode(StatusCodes.Status200OK, new { valor = res });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
