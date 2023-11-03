using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.DAL.DataContext;

namespace Universidad.DAL.Repository
{
    public class EstudianteRepository : IGenericRepository
    {
        private readonly UniversidadContext _dbContext;

        public EstudianteRepository(UniversidadContext universidadContext)
        {
            this._dbContext = universidadContext;
        }
        public async Task<bool> Actualizar(Student estudiante)
        {
            var Estudiante = new Student()
            {
                Id = estudiante.Id,
                FirstName = estudiante.FirstName,
                LasName = estudiante.LasName,
                Addres = estudiante.Addres,
                CellPhone = estudiante.CellPhone,
                Email = estudiante.Email,
                Descripcion = estudiante.Descripcion,
                CoursesId = estudiante.CoursesId,
                FechaCreacion = estudiante.FechaCreacion,
                FechaModificacion = DateTime.Now
            };

            this._dbContext.Students.Update(Estudiante);
            await this._dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            var estudiante = await this._dbContext.Students.FirstAsync(est => est.Id == id);

            this._dbContext.Students.Remove(estudiante);
            this._dbContext.SaveChanges();

            return true;
        }

        public async Task<bool> Insertar(Student estudiante)
        {
            var Estudiante = new Student()
            {
                FirstName = estudiante.FirstName,
                LasName = estudiante.LasName,
                Addres = estudiante.Addres,
                CellPhone = estudiante.CellPhone,
                Email = estudiante.Email,
                Descripcion = estudiante.Descripcion,
                CoursesId = estudiante.CoursesId,
                FechaCreacion = estudiante.FechaCreacion,
                FechaModificacion = DateTime.Now

            };
            this._dbContext.Students.Add(Estudiante);
            await this._dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Student> Obtener(int id)
        {
            var estudiante = await this._dbContext.Students.FirstOrDefaultAsync(est => est.Id==id);

            return estudiante;
        }

        public async Task<List<Student>> ObtenerTodos()
        {
            var estudiantes = await this._dbContext.Students.ToListAsync();
            
            return estudiantes;
        }
    }
}
