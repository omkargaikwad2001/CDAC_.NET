using System;
using System.Collections.Generic;

namespace P17_EntityFramework.Models;

public partial class Book
{
    public int Bookid { get; set; }

    public string? Name { get; set; }

    public float? Price { get; set; }
}
