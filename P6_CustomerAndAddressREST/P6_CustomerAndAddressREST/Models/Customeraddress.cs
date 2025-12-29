using System;
using System.Collections.Generic;

namespace P6_CustomerAndAddressREST.Models;

public partial class Customeraddress
{
    public int Id { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer? Customer { get; set; } = null!;
}
