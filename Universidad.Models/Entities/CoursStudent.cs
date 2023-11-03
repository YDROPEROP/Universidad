using System;
using System.Collections.Generic;

namespace Universidad.DAL.DataContext;

public partial class CoursStudent
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? CourseId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Student? Student { get; set; }
}
