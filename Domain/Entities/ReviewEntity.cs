using System.ComponentModel.DataAnnotations;
using Domain.Entities.Bases;

namespace Domain.Entities;

public class ReviewEntity:ParentEntity
{
    [Required]
    public DateTime ReviewTime { get; set;}
    [Required]
    public string Status { get; set; }
    public CustomerEntity customer {  get; set; }
        
    public ProductEntity product { get; set; }

}