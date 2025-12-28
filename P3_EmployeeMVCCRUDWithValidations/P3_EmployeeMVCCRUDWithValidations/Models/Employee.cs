using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P3_EmployeeMVCCRUDWithValidations.Models;

public partial class Employee
{
    [Required(ErrorMessage = "Id is must.")]
    public int? Id { get; set; }

    [Required(ErrorMessage = "Emp Name is must.")]
    [StringLength(45, MinimumLength = 3, ErrorMessage = "Emp name should be 3 to 45 char.")]
    public string? Ename { get; set; }

    [Required(ErrorMessage = "Salary is must.")]
    [Range(500, 50000, ErrorMessage = "Sal must be > 500 and < 50,000")]
    public float? Salary { get; set; }

    [Required(ErrorMessage = "Address  is must.")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Gender is must.")]
    public string? Gender { get; set; }

}
