using SistemaRegistroPersonas.DAL.Repositories;
using SistemaRegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroPersonas.BLL.Service
{
    public class RegistroPersonasService : IRegistroPersonasService
    {
        private readonly IGenericRepository<RegistroPersona> _registroRepo;
        //traemos el constructor
        public RegistroPersonasService(IGenericRepository<RegistroPersona> registroRepo)
        {
            _registroRepo = registroRepo;
        }
        //de requerirse puede incluir nuevos metodos en este servicio
        public async Task<bool> Actualizar(RegistroPersona modelo)
        {
            return await _registroRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _registroRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(RegistroPersona modelo)
        {
            return await _registroRepo.Insertar(modelo);
        }

        public async Task<RegistroPersona> Obtener(int id)
        {
            return await _registroRepo.Obtener(id);
        }
        
        public async Task<RegistroPersona> ObtenerIdentificacion(int identificacion)
        {
            return await _registroRepo.ObtenerIdentificacion(identificacion);
        }

        public async Task<IQueryable<RegistroPersona>> ObtenerTodos()
        {
            return await _registroRepo.ObtenerTodos();
        }
    }
}
