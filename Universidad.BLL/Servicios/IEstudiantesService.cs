using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.DAL.DataContext;

namespace Universidad.BLL.Servicios
{
    public interface IEstudiantesService
    {
        Task<bool> Insertar(Student estudiante);
        Task<bool> Actualizar(Student estudiante);
        Task<bool> Eliminar(int id);
        Task<Student> Obtener(int id);
        Task<List<Student>> ObtenerTodos();
    }
}
