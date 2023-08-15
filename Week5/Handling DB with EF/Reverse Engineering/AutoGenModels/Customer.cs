using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReverseEngineering;

[Table("Customer")]
public partial class Customer
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    public string? Name { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
