using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Universidad.BLL.Servicios;
using Universidad.DAL.DataContext;

namespace Universidad.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {

        private readonly IEstudiantesService _estudianteService;

        public EstudianteController(IEstudiantesService estudianteService)
        {
            this._estudianteService = estudianteService;
        }

        [HttpGet("ObtenerTodos")]
        public async Task<List<Student>> GetStudents()
        {
            return await this._estudianteService.ObtenerTodos();
        }
        [HttpGet("Obtener")]
        public async Task<Student> GetStudent(int id)
        {
            return await this._estudianteService.Obtener(id);
        }

        [HttpPost("Insertar")]
        public async Task<bool> Insertar(Student estudainte)
        {
            await this._estudianteService.Insertar(estudainte);
            return true;
        }
        [HttpDelete("Eliminar")]
        public async Task<bool> Eliminar(int id)
        {
            await this._estudianteService.Eliminar(id);

            return true;
        }
        [HttpPut("Actualizar")]
        public async Task<bool> Actualizar(Student estudiante)
        {
            await this._estudianteService.Actualizar(estudiante);
            
            return true;
        }

    } 
}
