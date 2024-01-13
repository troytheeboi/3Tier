using System.ComponentModel.DataAnnotations;
using Domain.Entities.Bases;

namespace Domain.Entities;

public class CategoryEntity:BaseEntity
{
    [Required]
    public string CatName { get; set; }
    [Required]
    public string CatDescription { get; set; }

    public virtual List<ProductEntity> Products { get; set; }

}