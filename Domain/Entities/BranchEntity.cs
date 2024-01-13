using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Bases;

namespace Domain.Entities;

public class BranchEntity: BaseEntity
{
    [Required]
    public string Location { get; set; }
    [Required]
    public int capacity { get; set; }

    public List<EmployeeEntity> employees { get; set; }

    public List<ProductEntity> products { get; set; }

    [ForeignKey("EmployeeEntity")]
    public int? ManagerID { get; set; }

}