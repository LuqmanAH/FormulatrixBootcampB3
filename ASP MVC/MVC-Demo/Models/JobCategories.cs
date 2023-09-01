using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Demo.Models;

public class JobCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    [InverseProperty("Division")]
    public ICollection<Job> Jobs { get; set; } = new List<Job>();
}
