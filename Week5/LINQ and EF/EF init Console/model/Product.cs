using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DB_First;


public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;

    [Column("UnitPrice", TypeName = "Money")]
    public decimal? Cost { get; set; }

    [Column("UnitsInStock")]
    public short? Stock {get; set; }

    public bool Discontinued {get; set; }

    public int CategoryID {get; set; }

    public virtual Category Category {get; set; } = null!;

}
