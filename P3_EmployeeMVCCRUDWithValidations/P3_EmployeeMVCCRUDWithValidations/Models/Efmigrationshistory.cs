using System;
using System.Collections.Generic;

namespace P3_EmployeeMVCCRUDWithValidations.Models;

public partial class Efmigrationshistory
{
    public string MigrationId { get; set; } = null!;

    public string ProductVersion { get; set; } = null!;
}
