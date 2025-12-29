using System;
using System.Collections.Generic;

namespace P6_CustomerAndAddressREST.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Customeraddress>? Customeraddresses { get; set; } = new List<Customeraddress>();
}
