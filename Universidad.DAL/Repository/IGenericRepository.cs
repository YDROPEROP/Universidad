using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.DAL.DataContext;

namespace Universidad.DAL.Repository
{
    public interface IGenericRepository
    {
        Task<bool> Insertar(Student est);
        Task<bool> Actualizar(Student est);
        Task<bool> Eliminar(int id);
        Task<Student> Obtener(int id);
        Task<List<Student>> ObtenerTodos();
    }
}
