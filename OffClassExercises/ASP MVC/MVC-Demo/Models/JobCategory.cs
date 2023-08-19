using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_Demo.Controllers;

namespace MVC_Demo.Models;

public class JobCategory
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Job> Jobs{ get; set; }

    public JobCategory()
    {
        Jobs = new HashSet<Job>();
    }
}
