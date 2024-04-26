using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroPersonas.DAL.Repositories
{
    public interface IGenericRepository<TEntityModel> where TEntityModel : class
    {
        //Declaramos los nombres de los metodos
        //Estos son los metodos basicos de crud, de necesitarse alguno en especifico, debe incluirse en cada repositorio
        Task<bool> Insertar(TEntityModel modelo);
        Task<bool> Actualizar(TEntityModel modelo);
        Task<bool> Eliminar(int id);
        Task<TEntityModel> Obtener(int id);
        Task<TEntityModel> ObtenerIdentificacion(int identificacion);
        Task<IQueryable<TEntityModel>> ObtenerTodos();
    }
}
