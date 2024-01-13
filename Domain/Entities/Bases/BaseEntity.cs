using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Bases;

public class BaseEntity : ParentEntity
{
    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public DateTime LastModified { get; set; }

    [Required]
    [ForeignKey("EmployeeEntity")]
    public int EmployeeId { get; set; }


}