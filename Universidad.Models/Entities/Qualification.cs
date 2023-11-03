using System;
using System.Collections.Generic;

namespace Universidad.DAL.DataContext;

public partial class Qualification
{
    public int Id { get; set; }

    public string? Nota { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
