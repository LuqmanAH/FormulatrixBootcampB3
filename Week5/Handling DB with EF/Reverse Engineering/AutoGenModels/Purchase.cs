using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReverseEngineering;

[Table("Purchase")]
[Index("CustomerId", Name = "IX_Purchase_CustomerID")]
public partial class Purchase
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("CustomerID")]
    public long? CustomerId { get; set; }

    public string Date { get; set; } = null!;

    public string? Description { get; set; }

    public double Price { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Purchases")]
    public virtual Customer? Customer { get; set; } = null!;
}
