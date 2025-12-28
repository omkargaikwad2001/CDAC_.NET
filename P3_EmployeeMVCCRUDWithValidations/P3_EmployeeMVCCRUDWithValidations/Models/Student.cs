using System;
using System.Collections.Generic;

namespace P3_EmployeeMVCCRUDWithValidations.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public double Fees { get; set; }
}
