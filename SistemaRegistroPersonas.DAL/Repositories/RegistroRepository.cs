using Microsoft.EntityFrameworkCore;
using SistemaRegistroPersonas.DAL.DataContext;
using SistemaRegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroPersonas.DAL.Repositories
{
    public class RegistroRepository : IGenericRepository<RegistroPersona>
    {
        private readonly DbRegistroPruebaContext _dbcontext;
        // creamos el constructor
        public RegistroRepository(DbRegistroPruebaContext context)
        {
            _dbcontext = context;
        }
        public async Task<bool> Actualizar(RegistroPersona modelo)
        {
            _dbcontext.RegistroPersonas.Update(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            RegistroPersona modelo = _dbcontext.RegistroPersonas.First(x => x.IdRegistro == id);
            _dbcontext.RegistroPersonas.Remove(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(RegistroPersona modelo)
        {
            _dbcontext.RegistroPersonas.Add(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<RegistroPersona> Obtener(int id)
        {
            return await _dbcontext.RegistroPersonas.FindAsync(id);
        }

        public async Task<IQueryable<RegistroPersona>> ObtenerTodos()
        {
            IQueryable<RegistroPersona> queryRegistro = _dbcontext.RegistroPersonas;
            return queryRegistro;
        }

        public async Task<RegistroPersona> ObtenerIdentificacion(int identificacion)
        {
            return await _dbcontext.RegistroPersonas.FirstOrDefaultAsync(x => x.Identificacion == identificacion);
        }
    }
}
