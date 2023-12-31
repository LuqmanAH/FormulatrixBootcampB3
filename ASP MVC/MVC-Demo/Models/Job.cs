﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Demo.Models;

public class Job
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JobId { get; set; }
    [Required]
    public string JobTitle { get; set; }
    [Required]
    public string JobDescription { get; set; }
    [Required]
    public string JobRequirements { get; set; }
    [Required]
    public int IsJobAvailable { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public string JobPostedDate { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public string JobExpiredDate { get; set; }
    public string? ProcessStatus { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Jobs")]
    public virtual JobCategory Division {get; set;} = null!;
}
