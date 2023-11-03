using System;
using System.Collections.Generic;

namespace Universidad.DAL.DataContext;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LasName { get; set; }

    public string? Addres { get; set; }

    public int? CellPhone { get; set; }

    public string? Email { get; set; }

    public string? Descripcion { get; set; }

    public int? CoursesId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<CoursStudent> CoursStudents { get; set; } = new List<CoursStudent>();

    public virtual Course? Courses { get; set; }
}
