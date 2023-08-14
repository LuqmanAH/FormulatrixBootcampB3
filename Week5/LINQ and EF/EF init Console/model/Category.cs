using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DB_First;


public class Category
{
    [Key]
    public int CategoryID {get; set;}

    [Required]
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? Description {get; set; }
    public virtual ICollection<Product> Products {get; set; }

    public Category()
    {
        Products = new HashSet<Product>();
    }
}