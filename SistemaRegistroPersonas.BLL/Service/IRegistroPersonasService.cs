using SistemaRegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroPersonas.BLL.Service
{
    public interface IRegistroPersonasService
    {
        Task<bool> Insertar(RegistroPersona modelo);
        Task<bool> Actualizar(RegistroPersona modelo);
        Task<bool> Eliminar(int id);
        Task<RegistroPersona> Obtener(int id);
        Task<RegistroPersona> ObtenerIdentificacion(int identificacion);
        Task<IQueryable<RegistroPersona>> ObtenerTodos();
    }
}
