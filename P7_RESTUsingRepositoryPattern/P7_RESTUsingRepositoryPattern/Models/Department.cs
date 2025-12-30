using System;
using System.Collections.Generic;

namespace P7_RESTUsingRepositoryPattern.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public virtual ICollection<Employee>? Employees { get; set; } = new List<Employee>();
}
