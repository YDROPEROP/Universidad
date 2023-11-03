using System;
using System.Collections.Generic;

namespace Universidad.DAL.DataContext;

public partial class Course
{
    public int Id { get; set; }

    public string? Names { get; set; }

    public int? QualificationsId { get; set; }

    public virtual ICollection<CoursStudent> CoursStudents { get; set; } = new List<CoursStudent>();

    public virtual Qualification? Qualifications { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
