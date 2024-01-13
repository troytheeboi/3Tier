using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Bases;

namespace Domain.Entities;

public class EmployeeEntity:PersonEntity
{
    [Required]
    public string Title { get; set; }
    [Required]
    public int Salary { get; set; }

    [ForeignKey("BranchEntity")]
    public int BranchId { get; set; } 
    public BranchEntity branch { get; set; }

}