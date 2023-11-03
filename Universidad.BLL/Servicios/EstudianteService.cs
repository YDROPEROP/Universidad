using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.DAL.DataContext;
using Universidad.DAL.Repository;

namespace Universidad.BLL.Servicios
{
    public class EstudianteService : IEstudiantesService
    {
        private readonly IGenericRepository _estudianteRepository;

        public EstudianteService(IGenericRepository genericRepository)
        {
            _estudianteRepository = genericRepository;
        }
        public async Task<bool> Actualizar(Student estudiante)
        {

            await this._estudianteRepository.Actualizar(estudiante);

            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            await this._estudianteRepository.Eliminar(id);

            return true;
        }

        public async Task<bool> Insertar(Student estudiante)
        {
            await this._estudianteRepository.Insertar(estudiante);

            return true;
        }

        public async Task<Student> Obtener(int id)
        {
            return await this._estudianteRepository.Obtener(id);
        }

        public async Task<List<Student>> ObtenerTodos()
        {
            return await this._estudianteRepository.ObtenerTodos();
        }
    }
}
